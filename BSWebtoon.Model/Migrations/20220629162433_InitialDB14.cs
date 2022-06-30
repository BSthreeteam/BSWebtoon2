using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWebtoon.Model.Migrations
{
    public partial class InitialDB14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ComicTagList",
                table: "ComicTagList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keyword",
                table: "ComicTagList",
                column: "TageListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Keyword",
                table: "ComicTagList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComicTagList",
                table: "ComicTagList",
                column: "TageListId");
        }
    }
}
