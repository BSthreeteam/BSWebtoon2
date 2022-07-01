using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWebtoon.Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditType",
                columns: table => new
                {
                    AuditTypeId = table.Column<int>(type: "int", nullable: false, comment: "審核類型")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditType", x => x.AuditTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CashPlan",
                columns: table => new
                {
                    CashPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CashPlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPlan", x => x.CashPlanId);
                });

            migrationBuilder.CreateTable(
                name: "ComicStatus",
                columns: table => new
                {
                    ComicStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicStatus", x => x.ComicStatusId);
                });

            migrationBuilder.CreateTable(
                name: "KeywordDetail",
                columns: table => new
                {
                    KeywordDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordDetail", x => x.KeywordDetailId);
                });

            migrationBuilder.CreateTable(
                name: "LoginType",
                columns: table => new
                {
                    LoginTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginType", x => x.LoginTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PayMethod",
                columns: table => new
                {
                    PayMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayMethodtype = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMethod", x => x.PayMethodId);
                });

            migrationBuilder.CreateTable(
                name: "ReportReason",
                columns: table => new
                {
                    ReportReasonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportReason", x => x.ReportReasonId);
                });

            migrationBuilder.CreateTable(
                name: "Comic",
                columns: table => new
                {
                    ComicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgPic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeoplePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bgc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateWeek = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicStatusId = table.Column<int>(type: "int", nullable: true),
                    TitleVideoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleVideoMp4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicVideoWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicVideoMp4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditTypeId = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    FailureCheckReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comic", x => x.ComicId);
                    table.ForeignKey(
                        name: "FK_Comic_ComicCheckType",
                        column: x => x.AuditTypeId,
                        principalTable: "AuditType",
                        principalColumn: "AuditTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comic_ComicStatus",
                        column: x => x.ComicStatusId,
                        principalTable: "ComicStatus",
                        principalColumn: "ComicStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: true, comment: "餘額"),
                    LoginTypeId = table.Column<int>(type: "int", nullable: false, comment: "登入型態"),
                    Setting = table.Column<bool>(type: "bit", nullable: false, comment: "設定")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Member_LoginType",
                        column: x => x.LoginTypeId,
                        principalTable: "LoginType",
                        principalColumn: "LoginTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Epsiode",
                columns: table => new
                {
                    EpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    EpTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClickCount = table.Column<int>(type: "int", nullable: true),
                    Epimg = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditTypeId = table.Column<int>(type: "int", nullable: false),
                    FailureCheckReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epsiode", x => x.EpId);
                    table.ForeignKey(
                        name: "FK_Epsiode_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GetTicketMethod",
                columns: table => new
                {
                    GetTicketMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GetTicketMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetTicketMethodStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GetTicketMethodEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ComicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetTicketMethod", x => x.GetTicketMethodId);
                    table.ForeignKey(
                        name: "FK_GetMethod_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeywordConnect",
                columns: table => new
                {
                    KeywordDetailId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Keyword_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Keyword_KeywordDetail",
                        column: x => x.KeywordDetailId,
                        principalTable: "KeywordDetail",
                        principalColumn: "KeywordDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CouponStock",
                columns: table => new
                {
                    CouponStockId = table.Column<int>(type: "int", nullable: false, comment: "劵庫存量"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponStock", x => x.CouponStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MyLove",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    NamePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeoplePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgcPic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bell = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_MyLove_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyLove_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RechargeRecord",
                columns: table => new
                {
                    RechargeRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CashPlanId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RechargeRecord", x => x.RechargeRecordId);
                    table.ForeignKey(
                        name: "FK_Recharge_Coin",
                        column: x => x.CashPlanId,
                        principalTable: "CashPlan",
                        principalColumn: "CashPlanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recharge_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recharge_PayMethod",
                        column: x => x.PayMethodId,
                        principalTable: "PayMethod",
                        principalColumn: "PayMethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComicPic",
                columns: table => new
                {
                    ComicPicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    Jpg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicPic", x => x.ComicPicId);
                    table.ForeignKey(
                        name: "FK_ComicPic_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComicPic_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Epsiode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    EpId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    ReplyToCommentId = table.Column<int>(type: "int", nullable: false),
                    LikeCount = table.Column<int>(type: "int", nullable: true),
                    Spoiler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CommentContext = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Comment",
                        column: x => x.ReplyToCommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Epsiode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    GetId = table.Column<int>(type: "int", nullable: false),
                    EpId = table.Column<int>(type: "int", nullable: false),
                    CouponStockId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Epsiode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UseRecord",
                columns: table => new
                {
                    UseRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    EpId = table.Column<int>(type: "int", nullable: false),
                    CouponStockId = table.Column<int>(type: "int", nullable: false),
                    UseDateSart = table.Column<DateTime>(type: "datetime", nullable: false),
                    UseDateEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseRecord", x => x.UseRecordId);
                    table.ForeignKey(
                        name: "FK_UseRecord_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Epsiode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UseRecord_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UseRecord_Stocks",
                        column: x => x.CouponStockId,
                        principalTable: "CouponStock",
                        principalColumn: "CouponStockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViewRecord",
                columns: table => new
                {
                    EpId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    ComicId = table.Column<int>(type: "int", nullable: false),
                    PeoplePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgPic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicPicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ViewRecord_Comic",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ComicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ViewRecord_ComicPic",
                        column: x => x.ComicPicId,
                        principalTable: "ComicPic",
                        principalColumn: "ComicPicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ViewRecord_Epsiode",
                        column: x => x.EpId,
                        principalTable: "Epsiode",
                        principalColumn: "EpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ViewRecord_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    BeReportedMemberId = table.Column<int>(type: "int", nullable: false),
                    ReportMemberId = table.Column<int>(type: "int", nullable: false),
                    ReportReasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Report_Comment",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Member",
                        column: x => x.BeReportedMemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Member1",
                        column: x => x.ReportMemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_ReportReason",
                        column: x => x.ReportReasonId,
                        principalTable: "ReportReason",
                        principalColumn: "ReportReasonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comic_AuditTypeId",
                table: "Comic",
                column: "AuditTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comic_ComicStatusId",
                table: "Comic",
                column: "ComicStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicPic_ComicId",
                table: "ComicPic",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicPic_EpId",
                table: "ComicPic",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ComicId",
                table: "Comment",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_EpId",
                table: "Comment",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ReplyToCommentId",
                table: "Comment",
                column: "ReplyToCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponStock_ComicId",
                table: "CouponStock",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponStock_MemberId",
                table: "CouponStock",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Epsiode_ComicId",
                table: "Epsiode",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_GetTicketMethod_ComicId",
                table: "GetTicketMethod",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordConnect_ComicId",
                table: "KeywordConnect",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordConnect_KeywordDetailId",
                table: "KeywordConnect",
                column: "KeywordDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_LoginTypeId",
                table: "Member",
                column: "LoginTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLove_ComicId",
                table: "MyLove",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLove_MemberId",
                table: "MyLove",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EpId",
                table: "Order",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MemberId",
                table: "Order",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_CashPlanId",
                table: "RechargeRecord",
                column: "CashPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_MemberId",
                table: "RechargeRecord",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_RechargeRecord_PayMethodId",
                table: "RechargeRecord",
                column: "PayMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_BeReportedMemberId",
                table: "Report",
                column: "BeReportedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_CommentId",
                table: "Report",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReportMemberId",
                table: "Report",
                column: "ReportMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReportReasonId",
                table: "Report",
                column: "ReportReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_UseRecord_CouponStockId",
                table: "UseRecord",
                column: "CouponStockId");

            migrationBuilder.CreateIndex(
                name: "IX_UseRecord_EpId",
                table: "UseRecord",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_UseRecord_MemberId",
                table: "UseRecord",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_ComicId",
                table: "ViewRecord",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_ComicPicId",
                table: "ViewRecord",
                column: "ComicPicId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_EpId",
                table: "ViewRecord",
                column: "EpId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewRecord_MemberId",
                table: "ViewRecord",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetTicketMethod");

            migrationBuilder.DropTable(
                name: "KeywordConnect");

            migrationBuilder.DropTable(
                name: "MyLove");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "RechargeRecord");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "UseRecord");

            migrationBuilder.DropTable(
                name: "ViewRecord");

            migrationBuilder.DropTable(
                name: "KeywordDetail");

            migrationBuilder.DropTable(
                name: "CashPlan");

            migrationBuilder.DropTable(
                name: "PayMethod");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "ReportReason");

            migrationBuilder.DropTable(
                name: "CouponStock");

            migrationBuilder.DropTable(
                name: "ComicPic");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Epsiode");

            migrationBuilder.DropTable(
                name: "LoginType");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "AuditType");

            migrationBuilder.DropTable(
                name: "ComicStatus");
        }
    }
}
