using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWebtoon.Model.Migrations
{
    public partial class InitialDB8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComicName",
                table: "Comic");

            migrationBuilder.AddColumn<string>(
                name: "ComicChineseName",
                table: "Comic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "漫畫中文名稱");

            migrationBuilder.AddColumn<string>(
                name: "ComicEnglishName",
                table: "Comic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "漫畫英文名稱");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComicChineseName",
                table: "Comic");

            migrationBuilder.DropColumn(
                name: "ComicEnglishName",
                table: "Comic");

            migrationBuilder.AddColumn<string>(
                name: "ComicName",
                table: "Comic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "漫畫名稱");
        }
    }
}
