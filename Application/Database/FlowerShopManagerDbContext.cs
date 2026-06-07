using Application.Domain;
using Microsoft.EntityFrameworkCore; //da moje objekte mapira na tabele bazi podataka

namespace Application.Database
{
    public class FlowerShopManagerDbContext : DbContext
    {
        //svaki db set predstavlja tabelu u bazi podataka, a tip parametra predstavlja model koji se mapira na tu tabelu
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        
        private static string GetDbPath() //da se dobije ista putanja do baze
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dir = Path.Combine(folder, "FlowerShopManager");
            Directory.CreateDirectory(dir);//ako ne postoji folder, kreira se
            return Path.Combine(dir, "FlowerShop.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) //govori entity framework u gde se nalazi baza podataka
        {
            options.UseSqlite($"Data Source={GetDbPath()}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);

            //update bazu dotnet ef migrations add <Naziv promene> --project Application
            // dotnet ef database update --project Application da se napravi db file sa tim izmenama
            // Users
            modelBuilder.Entity<User>().HasData(
                new { Id = 1, FirstName = "Alice", LastName = "Admin", Email = "alice@flowerShop.com", Password = "hashed_pw_1", CreatedAt = new DateTime(2024, 1, 1), Role = UserRole.Admin },
                new { Id = 2, FirstName = "Bob", LastName = "Staff", Email = "bob@flowerShop.com", Password = "hashed_pw_2", CreatedAt = new DateTime(2024, 1, 5), Role = UserRole.Staff },
                new { Id = 3, FirstName = "Carol", LastName = "Customer", Email = "carol@example.com", Password = "hashed_pw_3", CreatedAt = new DateTime(2024, 2, 10), Role = UserRole.Customer },
                new { Id = 4, FirstName = "David", LastName = "Customer", Email = "david@example.com", Password = "hashed_pw_4", CreatedAt = new DateTime(2024, 3, 15), Role = UserRole.Customer },
                new { Id = 5, FirstName = "David", LastName = "Customer", Email = "123", Password = "123", CreatedAt = new DateTime(2024, 3, 15), Role = UserRole.Admin },
                new { Id = 6, FirstName = "zoki", LastName = "Customer", Email = "111", Password = "111", CreatedAt = new DateTime(2025, 3, 12), Role = UserRole.Customer },
                new { Id = 7, FirstName = "nikola", LastName = "Customer", Email = "222", Password = "222", CreatedAt = new DateTime(2025, 3, 15), Role = UserRole.Customer },
                new { Id = 8, FirstName = "milos", LastName = "Customer", Email = "444", Password = "444", CreatedAt = new DateTime(2025, 3, 18), Role = UserRole.Customer },
                new { Id = 9, FirstName = "marko", LastName = "Customer", Email = "333", Password = "333", CreatedAt = new DateTime(2025, 3, 20), Role = UserRole.Customer },
                new { Id = 10, FirstName = "didi", LastName = "Customer", Email = "321", Password = "321", CreatedAt = new DateTime(2025, 3, 25), Role = UserRole.Customer },
                new { Id = 11, FirstName = "vule", LastName = "Customer", Email = "122", Password = "122", CreatedAt = new DateTime(2025, 3, 25), Role = UserRole.Customer },
                new { Id = 12, FirstName = "miki", LastName = "Customer", Email = "124", Password = "124", CreatedAt = new DateTime(2025, 3, 27), Role = UserRole.Customer },
                new { Id = 13, FirstName = "maca", LastName = "Customer", Email = "555", Password = "555", CreatedAt = new DateTime(2025, 3, 28), Role = UserRole.Staff }
            );

            // Products
            modelBuilder.Entity<Product>().HasData(
                new { Id = 1, Name = "Red Roses Bouquet", Description = "Classic bouquet of 12 fresh red roses.", Price = 29.99, Stock = 50 },
                new { Id = 2, Name = "Sunflower Arrangement", Description = "Bright arrangement of 6 sunflowers.", Price = 19.99, Stock = 40 },
                new { Id = 3, Name = "Lavender Bundle", Description = "Dried lavender bundle, great for home decor.", Price = 12.49, Stock = 100 },
                new { Id = 4, Name = "Mixed Spring Bouquet", Description = "Seasonal mix of tulips, daisies and peonies.", Price = 34.99, Stock = 30 },
                new { Id = 5, Name = "Orchid Plant", Description = "Potted white orchid, long-lasting gift.", Price = 44.99, Stock = 20 },
                new { Id = 6, Name = "Succulent Garden", Description = "Assorted succulents in a decorative pot.", Price = 24.99, Stock = 60 },
                new { Id = 7, Name = "Carnation Bunch", Description = "Bunch of 10 colorful carnations.", Price = 14.99, Stock = 80 },
                new { Id = 8, Name = "Peony Bouquet", Description = "Elegant bouquet of 8 peonies.", Price = 39.99, Stock = 25 },
                new { Id = 9, Name = "Daisy Basket", Description = "Basket of cheerful daisies.", Price = 22.99, Stock = 45 },
                new { Id = 10, Name = "Tulip Mix", Description = "Vibrant mix of 15 tulips.", Price = 27.99, Stock = 35 },
                new { Id = 11, Name = "Gardenia Plant", Description = "Fragrant gardenia in a decorative pot.", Price = 34.99, Stock = 15 },
                new { Id = 12, Name = "Iris Bouquet", Description = "Beautiful bouquet of 10 irises.", Price = 31.99, Stock = 20 }

            );

            // Orders
            modelBuilder.Entity<Order>().HasData(
                new { Id = 1, CustomerId = 3, OrderDate = new DateTime(2024, 4, 1, 10, 0, 0), TotalAmount = 49.98, Status = OrderStatus.Completed },
                new { Id = 2, CustomerId = 4, OrderDate = new DateTime(2024, 4, 3, 14, 30, 0), TotalAmount = 34.99, Status = OrderStatus.Processing },
                new { Id = 3, CustomerId = 3, OrderDate = new DateTime(2024, 4, 10, 9, 15, 0), TotalAmount = 12.49, Status = OrderStatus.Pending },
                new { Id = 4, CustomerId = 5, OrderDate = new DateTime(2024, 4, 12, 11, 0, 0), TotalAmount = 64.98, Status = OrderStatus.Cancelled },
                new { Id = 5, CustomerId = 6, OrderDate = new DateTime(2025, 4, 15, 16, 45, 0), TotalAmount = 24.99, Status = OrderStatus.Processing },
                new { Id = 6, CustomerId = 7, OrderDate = new DateTime(2025, 4, 18, 13, 20, 0), TotalAmount = 39.99, Status = OrderStatus.Completed },
                new { Id = 7, CustomerId = 8, OrderDate = new DateTime(2025, 4, 20, 10, 10, 0), TotalAmount = 22.99, Status = OrderStatus.Pending },
                new { Id = 8, CustomerId = 9, OrderDate = new DateTime(2025, 4, 22, 15, 30, 0), TotalAmount = 27.99, Status = OrderStatus.Processing },
                new { Id = 9, CustomerId = 10, OrderDate = new DateTime(2025, 4, 25, 12, 0, 0), TotalAmount = 34.99, Status = OrderStatus.Cancelled },
                new { Id = 10, CustomerId = 11, OrderDate = new DateTime(2025, 4, 28, 14, 0, 0), TotalAmount = 31.99, Status = OrderStatus.Completed }
            );

            // OrderItems 
            modelBuilder.Entity<OrderItem>().HasData(
                new { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 29.99 },
                new { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 19.99 },
                new { Id = 3, OrderId = 2, ProductId = 4, Quantity = 1, UnitPrice = 34.99 },
                new { Id = 4, OrderId = 3, ProductId = 3, Quantity = 1, UnitPrice = 12.49 },
                new { Id = 5, OrderId = 4, ProductId = 5, Quantity = 1, UnitPrice = 44.99 },
                new { Id = 6, OrderId = 4, ProductId = 6, Quantity = 1, UnitPrice = 24.99 },
                new { Id = 7, OrderId = 5, ProductId = 6, Quantity = 1, UnitPrice = 14.99 },
                new { Id = 8, OrderId = 6, ProductId = 8, Quantity = 1, UnitPrice = 39.99 }
            );

            //Payments nje mi jasno
            modelBuilder.Entity<Payment>().HasData(
                new { Id = 1, OrderId = 1, Amount = 49.98, Date = new DateTime(2024, 4, 1, 10, 5, 0), Status = PaymentStatus.Completed },
                new { Id = 2, OrderId = 2, Amount = 34.99, Date = new DateTime(2024, 4, 3, 14, 35, 0), Status = PaymentStatus.Pending },
                new { Id = 3, OrderId = 3, Amount = 12.49, Date = new DateTime(2024, 4, 10, 9, 20, 0), Status = PaymentStatus.Pending },
                new { Id = 4, OrderId = 4, Amount = 64.98, Date = new DateTime(2024, 4, 12, 11, 5, 0), Status = PaymentStatus.Failed },
                new { Id = 5, OrderId = 5, Amount = 24.99, Date = new DateTime(2025, 4, 15, 16, 50, 0), Status = PaymentStatus.Pending },
                new { Id = 6, OrderId = 6, Amount = 39.99, Date = new DateTime(2025, 4, 18, 13, 25, 0), Status = PaymentStatus.Completed },
                new { Id = 7, OrderId = 7, Amount = 22.99, Date = new DateTime(2025, 4, 20, 10, 15, 0), Status = PaymentStatus.Pending }
            );

            // Reports
            modelBuilder.Entity<Report>().HasData(
                new { Id = 1, GeneratedById = 1, Title = "April Sales Summary", Content = "Total sales in April: $97.46 across 3 orders.", CreatedAt = new DateTime(2024, 4, 30) },
                new { Id = 2, GeneratedById = 2, Title = "Low Stock Alert Report", Content = "Orchid Plant stock is below 25 units. Reorder advised.", CreatedAt = new DateTime(2024, 4, 15) },
                new { Id = 3, GeneratedById = 1, Title = "Customer Activity Report", Content = "Top customers in April: Carol (2 orders), David (1 order).", CreatedAt = new DateTime(2024, 4, 30) },
                new { Id = 4, GeneratedById = 2, Title = "Product Performance Report", Content = "Best-selling product in April: Red Roses Bouquet (1 unit sold).", CreatedAt = new DateTime(2024, 4, 30) }
            );

            //Notifications
            modelBuilder.Entity<Notification>().HasData(
                new { Id = 1, RecieverId = 3, Message = "Your order #1 has been completed!", IsSeen = true, CreatedAt = new DateTime(2024, 4, 1, 10, 6, 0) },
                new { Id = 2, RecieverId = 4, Message = "Your order #2 is currently being processed.", IsSeen = false, CreatedAt = new DateTime(2024, 4, 3, 14, 36, 0) },
                new { Id = 3, RecieverId = 3, Message = "Your order #3 has been received.", IsSeen = false, CreatedAt = new DateTime(2024, 4, 10, 9, 21, 0) },
                new { Id = 4, RecieverId = 2, Message = "Low stock alert: Orchid Plant has 20 units.", IsSeen = true, CreatedAt = new DateTime(2024, 4, 15) },
                new { Id = 5, RecieverId = 1, Message = "April sales report has been generated.", IsSeen = true, CreatedAt = new DateTime(2024, 4, 30) }
            );
        }
    }
}
