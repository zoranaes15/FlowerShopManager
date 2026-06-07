using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsSeen", "Message", "RecieverId" },
                values: new object[] { 5, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "April sales report has been generated.", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status", "TotalAmount" },
                values: new object[] { 4, 5, new DateTime(2024, 4, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, 64.980000000000004 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 6, "Assorted succulents in a decorative pot.", "Succulent Garden", 24.989999999999998, 60 },
                    { 7, "Bunch of 10 colorful carnations.", "Carnation Bunch", 14.99, 80 },
                    { 8, "Elegant bouquet of 8 peonies.", "Peony Bouquet", 39.990000000000002, 25 },
                    { 9, "Basket of cheerful daisies.", "Daisy Basket", 22.989999999999998, 45 },
                    { 10, "Vibrant mix of 15 tulips.", "Tulip Mix", 27.989999999999998, 35 },
                    { 11, "Fragrant gardenia in a decorative pot.", "Gardenia Plant", 34.990000000000002, 15 },
                    { 12, "Beautiful bouquet of 10 irises.", "Iris Bouquet", 31.989999999999998, 20 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Content", "CreatedAt", "GeneratedById", "Title" },
                values: new object[,]
                {
                    { 3, "Top customers in April: Carol (2 orders), David (1 order).", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Customer Activity Report" },
                    { 4, "Best-selling product in April: Red Roses Bouquet (1 unit sold).", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Product Performance Report" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "111", "zoki", "Customer", "111", 2 },
                    { 7, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "222", "nikola", "Customer", "222", 2 },
                    { 8, new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "444", "milos", "Customer", "444", 2 },
                    { 9, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "333", "marko", "Customer", "333", 2 },
                    { 10, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "321", "didi", "Customer", "321", 2 },
                    { 11, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "122", "vule", "Customer", "122", 2 },
                    { 12, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "124", "miki", "Customer", "124", 2 },
                    { 13, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "555", "maca", "Customer", "555", 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 5, 4, 5, 1, 44.990000000000002 },
                    { 6, 4, 6, 1, 24.989999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 5, 6, new DateTime(2025, 4, 15, 16, 45, 0, 0, DateTimeKind.Unspecified), 1, 24.989999999999998 },
                    { 6, 7, new DateTime(2025, 4, 18, 13, 20, 0, 0, DateTimeKind.Unspecified), 2, 39.990000000000002 },
                    { 7, 8, new DateTime(2025, 4, 20, 10, 10, 0, 0, DateTimeKind.Unspecified), 0, 22.989999999999998 },
                    { 8, 9, new DateTime(2025, 4, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, 27.989999999999998 },
                    { 9, 10, new DateTime(2025, 4, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 34.990000000000002 },
                    { 10, 11, new DateTime(2025, 4, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 31.989999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Date", "OrderId", "Status" },
                values: new object[] { 4, 64.980000000000004, new DateTime(2024, 4, 12, 11, 5, 0, 0, DateTimeKind.Unspecified), 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 7, 5, 6, 1, 14.99 },
                    { 8, 6, 8, 1, 39.990000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Date", "OrderId", "Status" },
                values: new object[,]
                {
                    { 5, 24.989999999999998, new DateTime(2025, 4, 15, 16, 50, 0, 0, DateTimeKind.Unspecified), 5, 0 },
                    { 6, 39.990000000000002, new DateTime(2025, 4, 18, 13, 25, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 7, 22.989999999999998, new DateTime(2025, 4, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), 7, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
