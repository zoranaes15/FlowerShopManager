using Application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Database
{
    public class FlowerShopManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Database/FlowerShop.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ── Users ────────────────────────────────────────────────────────
            modelBuilder.Entity<User>().HasData(
                new { Id = 1, FirstName = "Alice", LastName = "Admin", Email = "alice@flowerShop.com", Password = "hashed_pw_1", CreatedAt = new DateTime(2024, 1, 1), Role = UserRole.Admin },
                new { Id = 2, FirstName = "Bob", LastName = "Staff", Email = "bob@flowerShop.com", Password = "hashed_pw_2", CreatedAt = new DateTime(2024, 1, 5), Role = UserRole.Staff },
                new { Id = 3, FirstName = "Carol", LastName = "Customer", Email = "carol@example.com", Password = "hashed_pw_3", CreatedAt = new DateTime(2024, 2, 10), Role = UserRole.Customer },
                new { Id = 4, FirstName = "David", LastName = "Customer", Email = "david@example.com", Password = "hashed_pw_4", CreatedAt = new DateTime(2024, 3, 15), Role = UserRole.Customer }
            );

            // ── Products ─────────────────────────────────────────────────────
            modelBuilder.Entity<Product>().HasData(
                new { Id = 1, Name = "Red Roses Bouquet", Description = "Classic bouquet of 12 fresh red roses.", Price = 29.99, Stock = 50 },
                new { Id = 2, Name = "Sunflower Arrangement", Description = "Bright arrangement of 6 sunflowers.", Price = 19.99, Stock = 40 },
                new { Id = 3, Name = "Lavender Bundle", Description = "Dried lavender bundle, great for home decor.", Price = 12.49, Stock = 100 },
                new { Id = 4, Name = "Mixed Spring Bouquet", Description = "Seasonal mix of tulips, daisies and peonies.", Price = 34.99, Stock = 30 },
                new { Id = 5, Name = "Orchid Plant", Description = "Potted white orchid, long-lasting gift.", Price = 44.99, Stock = 20 }
            );

            // ── Orders ───────────────────────────────────────────────────────
            modelBuilder.Entity<Order>().HasData(
                new { Id = 1, CustomerId = 3, OrderDate = new DateTime(2024, 4, 1, 10, 0, 0), TotalAmount = 49.98, Status = OrderStatus.Completed },
                new { Id = 2, CustomerId = 4, OrderDate = new DateTime(2024, 4, 3, 14, 30, 0), TotalAmount = 34.99, Status = OrderStatus.Processing },
                new { Id = 3, CustomerId = 3, OrderDate = new DateTime(2024, 4, 10, 9, 15, 0), TotalAmount = 12.49, Status = OrderStatus.Pending }
            );

            // ── OrderItems ────────────────────────────────────────────────────
            modelBuilder.Entity<OrderItem>().HasData(
                new { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 29.99 },
                new { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 19.99 },
                new { Id = 3, OrderId = 2, ProductId = 4, Quantity = 1, UnitPrice = 34.99 },
                new { Id = 4, OrderId = 3, ProductId = 3, Quantity = 1, UnitPrice = 12.49 }
            );

            // ── Payments ─────────────────────────────────────────────────────
            modelBuilder.Entity<Payment>().HasData(
                new { Id = 1, OrderId = 1, Amount = 49.98, Date = new DateTime(2024, 4, 1, 10, 5, 0), Status = PaymentStatus.Completed },
                new { Id = 2, OrderId = 2, Amount = 34.99, Date = new DateTime(2024, 4, 3, 14, 35, 0), Status = PaymentStatus.Pending },
                new { Id = 3, OrderId = 3, Amount = 12.49, Date = new DateTime(2024, 4, 10, 9, 20, 0), Status = PaymentStatus.Pending }
            );

            // ── Reports ──────────────────────────────────────────────────────
            modelBuilder.Entity<Report>().HasData(
                new { Id = 1, GeneratedById = 1, Title = "April Sales Summary", Content = "Total sales in April: $97.46 across 3 orders.", CreatedAt = new DateTime(2024, 4, 30) },
                new { Id = 2, GeneratedById = 2, Title = "Low Stock Alert Report", Content = "Orchid Plant stock is below 25 units. Reorder advised.", CreatedAt = new DateTime(2024, 4, 15) }
            );

            // ── Notifications ─────────────────────────────────────────────────
            modelBuilder.Entity<Notification>().HasData(
                new { Id = 1, RecieverId = 3, Message = "Your order #1 has been completed!", IsSeen = true, CreatedAt = new DateTime(2024, 4, 1, 10, 6, 0) },
                new { Id = 2, RecieverId = 4, Message = "Your order #2 is currently being processed.", IsSeen = false, CreatedAt = new DateTime(2024, 4, 3, 14, 36, 0) },
                new { Id = 3, RecieverId = 3, Message = "Your order #3 has been received.", IsSeen = false, CreatedAt = new DateTime(2024, 4, 10, 9, 21, 0) },
                new { Id = 4, RecieverId = 2, Message = "Low stock alert: Orchid Plant has 20 units.", IsSeen = true, CreatedAt = new DateTime(2024, 4, 15) }
            );
        }
    }
}
