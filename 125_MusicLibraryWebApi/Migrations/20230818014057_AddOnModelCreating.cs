using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _125_MusicLibraryWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 4, "Sea Change", "Beck", "Alternative", new DateTime(2023, 8, 17, 21, 40, 57, 466, DateTimeKind.Local).AddTicks(5548), "The Golden Age" },
                    { 5, "TestSea Change", "TestBeck", "TestAlternative", new DateTime(2023, 8, 17, 21, 40, 57, 466, DateTimeKind.Local).AddTicks(5607), "TestTitle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
