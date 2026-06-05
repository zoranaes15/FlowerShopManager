using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class TestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Classic bouquet of 12 fresh red roses.", "Red Roses Bouquet", 29.989999999999998, 50 },
                    { 2, "Bright arrangement of 6 sunflowers.", "Sunflower Arrangement", 19.989999999999998, 40 },
                    { 3, "Dried lavender bundle, great for home decor.", "Lavender Bundle", 12.49, 100 },
                    { 4, "Seasonal mix of tulips, daisies and peonies.", "Mixed Spring Bouquet", 34.990000000000002, 30 },
                    { 5, "Potted white orchid, long-lasting gift.", "Orchid Plant", 44.990000000000002, 20 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@flowerShop.com", "Alice", "Admin", "hashed_pw_1", 0 },
                    { 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@flowerShop.com", "Bob", "Staff", "hashed_pw_2", 1 },
                    { 3, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "carol@example.com", "Carol", "Customer", "hashed_pw_3", 2 },
                    { 4, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "david@example.com", "David", "Customer", "hashed_pw_4", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsSeen", "Message", "RecieverId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), true, "Your order #1 has been completed!", 3 },
                    { 2, new DateTime(2024, 4, 3, 14, 36, 0, 0, DateTimeKind.Unspecified), false, "Your order #2 is currently being processed.", 4 },
                    { 3, new DateTime(2024, 4, 10, 9, 21, 0, 0, DateTimeKind.Unspecified), false, "Your order #3 has been received.", 3 },
                    { 4, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Low stock alert: Orchid Plant has 20 units.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 49.979999999999997 },
                    { 2, 4, new DateTime(2024, 4, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 1, 34.990000000000002 },
                    { 3, 3, new DateTime(2024, 4, 10, 9, 15, 0, 0, DateTimeKind.Unspecified), 0, 12.49 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Content", "CreatedAt", "GeneratedById", "Title" },
                values: new object[,]
                {
                    { 1, "Total sales in April: $97.46 across 3 orders.", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "April Sales Summary" },
                    { 2, "Orchid Plant stock is below 25 units. Reorder advised.", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Low Stock Alert Report" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 29.989999999999998 },
                    { 2, 1, 2, 1, 19.989999999999998 },
                    { 3, 2, 4, 1, 34.990000000000002 },
                    { 4, 3, 3, 1, 12.49 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { 1, 49.979999999999997, new DateTime(2024, 4, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 34.990000000000002, new DateTime(2024, 4, 3, 14, 35, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 3, 12.49, new DateTime(2024, 4, 10, 9, 20, 0, 0, DateTimeKind.Unspecified), 3, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
