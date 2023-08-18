using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _125_MusicLibraryWebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModelSongField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Songs",
                newName: "ReleaseDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Songs",
                newName: "DateTime");
        }
    }
}
