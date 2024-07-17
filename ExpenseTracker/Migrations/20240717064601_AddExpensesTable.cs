using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddExpensesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Planned = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryId", "Date", "Planned", "Title" },
                values: new object[,]
                {
                    { 1, 100.0m, 1, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4301), true, "Grocery Shopping" },
                    { 2, 50.0m, 2, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4306), false, "Train Ticket" },
                    { 3, 30.0m, 3, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4307), true, "Movie Night" },
                    { 4, 200.0m, 4, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4308), true, "Online Course" },
                    { 5, 150.0m, 5, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4309), false, "New Jacket" },
                    { 6, 800.0m, 6, new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4310), true, "Rent" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CategoryId",
                table: "Expenses",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
