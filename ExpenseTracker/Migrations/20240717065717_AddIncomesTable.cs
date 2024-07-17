using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddIncomesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.InsertData(
                table: "Incomes",
                columns: new[] { "Id", "Amount", "CategoryId", "Date", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 500.0m, null, new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2384), "Freelance Gig", 0 },
                    { 2, 1000.0m, null, new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2388), "Scholarship Grant", 1 },
                    { 3, 200.0m, null, new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2390), "Birthday Gift", 2 },
                    { 4, 10000.0m, null, new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2392), "Lottery Prize", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_CategoryId",
                table: "Incomes",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 7, 17, 6, 46, 1, 677, DateTimeKind.Utc).AddTicks(4310));
        }
    }
}
