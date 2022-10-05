using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDianaRG.Migrations
{
    /// <inheritdoc />
    public partial class paramore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TodoItems",
                newName: "uri_Album");

            migrationBuilder.AddColumn<string>(
                name: "AlbumName",
                table: "TodoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "TodoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SongName",
                table: "TodoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumName",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "SongName",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "uri_Album",
                table: "TodoItems",
                newName: "Name");
        }
    }
}
