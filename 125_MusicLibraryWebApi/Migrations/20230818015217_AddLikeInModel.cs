using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _125_MusicLibraryWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddLikeInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Like", "ReleaseDate" },
                values: new object[] { 0, new DateTime(2023, 8, 17, 21, 52, 17, 212, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Like", "ReleaseDate" },
                values: new object[] { 0, new DateTime(2023, 8, 17, 21, 52, 17, 212, DateTimeKind.Local).AddTicks(6078) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "Songs");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 17, 21, 40, 57, 466, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 17, 21, 40, 57, 466, DateTimeKind.Local).AddTicks(5607));
        }
    }
}
