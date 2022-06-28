using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWebtoon.Model.Migrations
{
    public partial class InitialDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    RankId = table.Column<int>(type: "int", nullable: false, comment: "排行")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClickCount = table.Column<int>(type: "int", nullable: false, comment: "點擊數量"),
                    ComicId = table.Column<int>(type: "int", nullable: false, comment: "漫畫"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "排行時間(排名更新的時間  排名開始時間)"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "排名結束時間(保留但可以先塞入資料)"),
                    PreRank = table.Column<int>(type: "int", nullable: false, comment: "上次排名(以一00:00~下周一00:00)"),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "排名開始時間(保留但可以先塞入資料)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.RankId);
                    table.ForeignKey(
                        name: "FK_Rank_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rank_ComicId",
                table: "Rank",
                column: "ComicId");
        }
    }
}
