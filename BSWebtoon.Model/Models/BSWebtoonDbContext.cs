﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class BSWebtoonDbContext : DbContext
    {
        public BSWebtoonDbContext()
        {
        }

        public BSWebtoonDbContext(DbContextOptions<BSWebtoonDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<CashPlan> CashPlans { get; set; }
        public virtual DbSet<ClickRecord> ClickRecords { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<ComicTag> ComicTags { get; set; }
        public virtual DbSet<ComicTagList> ComicTagLists { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentLikeRecord> CommentLikeRecords { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponUsedRecord> CouponUsedRecords { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EpContent> EpContents { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<LoginType> LoginTypes { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<RechargeRecord> RechargeRecords { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ViewRecord> ViewRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=bswebtoon.database.windows.net; Database=BSWebtoonDb;User ID=bs;Password=P@ssword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_BIN");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.HasIndex(e => e.PrincipalEmployee, "IX_Activity_PrincipalEmployee");

                entity.Property(e => e.ActivityId).HasComment("活動Id");

                entity.Property(e => e.ActivityBgColor)
                    .IsRequired()
                    .HasComment("活動背景色");

                entity.Property(e => e.ActivityContent)
                    .IsRequired()
                    .HasComment("活動文案(HTML)");

                entity.Property(e => e.ActivityEndTime)
                    .HasColumnType("datetime")
                    .HasComment("活動結束時間");

                entity.Property(e => e.ActivityImage)
                    .IsRequired()
                    .HasComment("活動圖片");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasComment("活動名稱");

                entity.Property(e => e.ActivityStartTime)
                    .HasColumnType("datetime")
                    .HasComment("活動開始時間");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("活動建立時間");

                entity.Property(e => e.IsDelete).HasComment("刪除活動");

                entity.Property(e => e.PrincipalEmployee).HasComment("建立該活動的員工");

                entity.HasOne(d => d.PrincipalEmployeeNavigation)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.PrincipalEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_Employee");
            });

            modelBuilder.Entity<CashPlan>(entity =>
            {
                entity.ToTable("CashPlan");

                entity.Property(e => e.CashPlanId).HasComment("金幣儲值方案");

                entity.Property(e => e.CashPlanContent)
                    .IsRequired()
                    .HasComment("儲值方案內容");

                entity.Property(e => e.IsEnable).HasComment("是否啟用");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasComment("價錢");

                entity.Property(e => e.Sort).HasComment("排序");
            });

            modelBuilder.Entity<ClickRecord>(entity =>
            {
                entity.ToTable("ClickRecord");

                entity.HasIndex(e => e.ComicId, "IX_ClickRecord_ComicId");

                entity.HasIndex(e => e.MemberId, "IX_ClickRecord_MemberId");

                entity.Property(e => e.ClickRecordId).HasComment("點擊紀錄ID");

                entity.Property(e => e.ComicId).HasComment("漫畫Id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("點擊的時間");

                entity.Property(e => e.MemberId).HasComment("會員Id");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.ClickRecords)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClickRecord_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ClickRecords)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_ClickRecord_Member");
            });

            modelBuilder.Entity<Comic>(entity =>
            {
                entity.ToTable("Comic");

                entity.HasIndex(e => e.AuditEmployeeId, "IX_Comic_AuditEmployeeId");

                entity.Property(e => e.ComicId).HasComment("漫畫ID");

                entity.Property(e => e.AuditEmployeeId).HasComment("審核人員(也是上傳人員)");

                entity.Property(e => e.AuditFailReason).HasComment("審核失敗原因");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasComment("審核時間");

                entity.Property(e => e.AuditType).HasComment("審核狀態");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasComment("作者");

                entity.Property(e => e.BannerVideoWeb).HasComment("短影片");

                entity.Property(e => e.BgColor).HasComment("背景色");

                entity.Property(e => e.BgCover)
                    .IsRequired()
                    .HasComment("漫畫背景圖");

                entity.Property(e => e.ComicChineseName)
                    .IsRequired()
                    .HasComment("漫畫中文名稱");

                entity.Property(e => e.ComicEnglishName)
                    .IsRequired()
                    .HasComment("漫畫英文名稱");

                entity.Property(e => e.ComicFigure).HasComment("人物圖");

                entity.Property(e => e.ComicNameImage)
                    .IsRequired()
                    .HasComment("漫畫名稱圖");

                entity.Property(e => e.ComicStatus).HasComment("漫畫狀態");

                entity.Property(e => e.ComicVideoWeb).HasComment("長影片");

                entity.Property(e => e.ComicWeekFigure).HasComment("星期列表人物圖");

                entity.Property(e => e.FinallyPublishDate)
                    .HasColumnType("datetime")
                    .HasComment("完結日期");

                entity.Property(e => e.HotBgCover).HasComment("強檔劇獻背景圖");

                entity.Property(e => e.HotComicNameImage).HasComment("強檔劇獻名稱圖");

                entity.Property(e => e.HotVideo).HasComment("強檔劇獻影片");

                entity.Property(e => e.Introduction)
                    .IsRequired()
                    .HasComment("故事大綱");

                entity.Property(e => e.LastPublishDate)
                    .HasColumnType("datetime")
                    .HasComment("最後更新日期");

                entity.Property(e => e.Painter).HasComment("繪者");

                entity.Property(e => e.PublishDate)
                    .HasColumnType("datetime")
                    .HasComment("發行日期");

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasComment("出版商");

                entity.Property(e => e.UpdateWeek).HasComment("更新星期");

                entity.Property(e => e.WeekVideoWrb).HasComment("星期列表影片");

                entity.HasOne(d => d.AuditEmployee)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.AuditEmployeeId)
                    .HasConstraintName("FK_Comic_Employee");
            });

            modelBuilder.Entity<ComicTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_KeywordDetail");

                entity.ToTable("ComicTag");

                entity.Property(e => e.TagId).HasComment("關鍵表Id");

                entity.Property(e => e.IsDelete).HasComment("是否刪除該標籤");

                entity.Property(e => e.IsMainTag).HasComment("是否為主要的Tag");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasComment("關鍵名稱");
            });

            modelBuilder.Entity<ComicTagList>(entity =>
            {
                entity.HasKey(e => e.TageListId);

                entity.ToTable("ComicTagList");

                entity.HasIndex(e => e.ComicId, "IX_ComicTagList_ComicId");

                entity.HasIndex(e => e.TagId, "IX_ComicTagList_TagId");

                entity.Property(e => e.TageListId).HasComment("關鍵字清單ID");

                entity.Property(e => e.ComicId).HasComment("漫畫Id");

                entity.Property(e => e.TagId).HasComment("關鍵字Id(以第一個為最主要的標籤)");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.ComicTagLists)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicTag_Comic");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ComicTagLists)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicTag_KeywordDetail");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.HasIndex(e => e.EpId, "IX_Comment_EpId");

                entity.HasIndex(e => e.MemberId, "IX_Comment_MemberId");

                entity.HasIndex(e => e.ReplyToCommentId, "IX_Comment_ReplyToCommentId");

                entity.Property(e => e.CommentId).HasComment("評論Id");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasComment("評論內容");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("評論時間");

                entity.Property(e => e.EpId).HasComment("集數Id");

                entity.Property(e => e.IsDelete).HasComment("是否刪除");

                entity.Property(e => e.IsSpoiler).HasComment("是否暴雷");

                entity.Property(e => e.MemberId).HasComment("會員Id");

                entity.Property(e => e.ReplyToCommentId).HasComment("被回復評論Id");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Member");

                entity.HasOne(d => d.ReplyToComment)
                    .WithMany(p => p.InverseReplyToComment)
                    .HasForeignKey(d => d.ReplyToCommentId)
                    .HasConstraintName("FK_Comment_Comment");
            });

            modelBuilder.Entity<CommentLikeRecord>(entity =>
            {
                entity.HasKey(e => e.CommentLikesId)
                    .HasName("PK_Likes");

                entity.ToTable("CommentLikeRecord");

                entity.HasIndex(e => e.CommentId, "IX_CommentLikeRecord_CommentId");

                entity.HasIndex(e => e.MemberId, "IX_CommentLikeRecord_MemberId");

                entity.Property(e => e.CommentLikesId).HasComment("留言按讚數Id");

                entity.Property(e => e.CommentId).HasComment("評論Id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("按讚時間");

                entity.Property(e => e.IsLike).HasComment("是否按讚");

                entity.Property(e => e.MemberId).HasComment("會員Id");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentLikeRecords)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Likes_Comment");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.CommentLikeRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Likes_Member");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.HasIndex(e => e.ActivityId, "IX_Coupon_ActivityId");

                entity.HasIndex(e => e.ComicId, "IX_Coupon_ComicId");

                entity.Property(e => e.CouponId).HasComment("劵ID");

                entity.Property(e => e.ActivityId).HasComment("活動Id");

                entity.Property(e => e.ComicId).HasComment("漫畫Id");

                entity.Property(e => e.CouponTypeId).HasComment("券的類型Id(有通用券跟倒數券、閱讀)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("取得時間");

                entity.Property(e => e.OriginQuantity).HasComment("原始數量");

                entity.Property(e => e.Quantity).HasComment("現有數量");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_Coupon_Activity");

                entity.HasOne(d => d.ActivityNavigation)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ReadCoupon_Epsiode");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.ComicId)
                    .HasConstraintName("FK_ReadCoupon_Comic");
            });

            modelBuilder.Entity<CouponUsedRecord>(entity =>
            {
                entity.HasKey(e => e.CouponRecordId)
                    .HasName("PK_UseRecord");

                entity.ToTable("CouponUsedRecord");

                entity.HasIndex(e => e.CouponId, "IX_CouponUsedRecord_CouponId");

                entity.HasIndex(e => e.EpId, "IX_CouponUsedRecord_EpId");

                entity.HasIndex(e => e.MemberId, "IX_CouponUsedRecord_MemberId");

                entity.Property(e => e.CouponRecordId).HasComment("券使用紀錄ID");

                entity.Property(e => e.CouponId).HasComment("券ID");

                entity.Property(e => e.EndReadTime)
                    .HasColumnType("datetime")
                    .HasComment("結束閱讀日期");

                entity.Property(e => e.EpId).HasComment("集數");

                entity.Property(e => e.MemberId).HasComment("會員");

                entity.Property(e => e.StartReadTime)
                    .HasColumnType("datetime")
                    .HasComment("開始閱讀日期");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponUsedRecords)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponUsedRecord_Coupon");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.CouponUsedRecords)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponUsedRecord_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.CouponUsedRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CouponUsedRecord_Member");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasComment("員工Id");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasComment("帳號");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasComment("員工姓名(也是上傳人員)");

                entity.Property(e => e.HireDate)
                    .HasColumnType("datetime")
                    .HasComment("雇用日期");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasComment("密碼(加密)");
            });

            modelBuilder.Entity<EpContent>(entity =>
            {
                entity.ToTable("EpContent");

                entity.HasIndex(e => e.EpId, "IX_EpContent_EpId");

                entity.Property(e => e.EpContentId).HasComment("漫畫圖片Id");

                entity.Property(e => e.EpId).HasComment("集數Id");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasComment("集數內容圖片路徑");

                entity.Property(e => e.Page).HasComment("頁次");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.EpContents)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicPic_Epsiode");
            });

            modelBuilder.Entity<Episode>(entity =>
            {
                entity.HasKey(e => e.EpId)
                    .HasName("PK_Epsiode");

                entity.ToTable("Episode");

                entity.HasIndex(e => e.AuditEmployeeId, "IX_Episode_AuditEmployeeId");

                entity.HasIndex(e => e.ComicId, "IX_Episode_ComicId");

                entity.Property(e => e.EpId).HasComment("集數ID");

                entity.Property(e => e.AuditEmployeeId).HasComment("審核人員(也是上傳人員)");

                entity.Property(e => e.AuditFailReason).HasComment("審核不通過原因");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasComment("審核時間");

                entity.Property(e => e.AuditType).HasComment("審核狀態ID");

                entity.Property(e => e.ComicId).HasComment("漫畫ID");

                entity.Property(e => e.EpCover)
                    .IsRequired()
                    .HasComment("集數封面照");

                entity.Property(e => e.EpTitle)
                    .IsRequired()
                    .HasComment("集數標題");

                entity.Property(e => e.IsCountdownCoupon).HasComment("是否可使用倒數免費券");

                entity.Property(e => e.IsFree).HasComment("是否為免費");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("更新時間");

                entity.Property(e => e.UploadTime)
                    .HasColumnType("datetime")
                    .HasComment("作者上傳的時間");

                entity.HasOne(d => d.AuditEmployee)
                    .WithMany(p => p.Episodes)
                    .HasForeignKey(d => d.AuditEmployeeId)
                    .HasConstraintName("FK_Episode_Employee");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Episodes)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Epsiode_Comic");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("Favorite");

                entity.HasIndex(e => e.ComicId, "IX_Favorite_ComicId");

                entity.HasIndex(e => e.MemberId, "IX_Favorite_MemberId");

                entity.Property(e => e.FavoriteId).HasComment("我的最愛Id");

                entity.Property(e => e.ComicId).HasComment("漫畫");

                entity.Property(e => e.MemberId).HasComment("會員");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Member");
            });

            modelBuilder.Entity<LoginType>(entity =>
            {
                entity.ToTable("LoginType");

                entity.Property(e => e.LoginTypeId).HasComment("登入方式Id");

                entity.Property(e => e.LoginTypeName)
                    .IsRequired()
                    .HasComment("登入類型名稱(不要有Apple)");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.HasIndex(e => e.LoginTypeId, "IX_Member_LoginTypeId");

                entity.Property(e => e.AccessToken).HasComment("記錄在該登入模式下的相關資料");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasComment("帳號名稱");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComment("餘額");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("創建時間");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasComment("Email");

                entity.Property(e => e.IsDarkTheme).HasComment("是否為深色模式(0=>白色 1=>黑色)");

                entity.Property(e => e.LoginTypeId).HasComment("登入類型");

                entity.Property(e => e.NameIdentifier)
                    .IsRequired()
                    .HasComment("第三方登入Id");

                entity.Property(e => e.NickName).HasComment("暱稱(作者)");

                entity.HasOne(d => d.LoginType)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.LoginTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_LoginType");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasComment("金流付款方式");

                entity.Property(e => e.IsEnable).HasComment("是否啟用該狀態");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasComment("付款方式類型名稱");

                entity.Property(e => e.Sort).HasComment("排序");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.ToTable("Rank");

                entity.HasIndex(e => e.ComicId, "IX_Rank_ComicId");

                entity.Property(e => e.RankId).HasComment("排行");

                entity.Property(e => e.ClickCount).HasComment("點擊數量");

                entity.Property(e => e.ComicId).HasComment("漫畫");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("排行時間(排名更新的時間  排名開始時間)");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("排名結束時間(保留但可以先塞入資料)");

                entity.Property(e => e.PreRank).HasComment("上次排名(以一00:00~下周一00:00)");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("排名開始時間(保留但可以先塞入資料)");
            });

            modelBuilder.Entity<RechargeRecord>(entity =>
            {
                entity.ToTable("RechargeRecord");

                entity.HasIndex(e => e.CashPlanId, "IX_RechargeRecord_CashPlanId");

                entity.HasIndex(e => e.MemberId, "IX_RechargeRecord_MemberId");

                entity.HasIndex(e => e.PaymentId, "IX_RechargeRecord_PaymentId");

                entity.Property(e => e.RechargeRecordId).HasComment("儲值ID");

                entity.Property(e => e.CashPlanContent).HasComment("儲值方案內容(EX:1200金幣)");

                entity.Property(e => e.CashPlanId).HasComment("金幣儲值方案Id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("儲值時間");

                entity.Property(e => e.MemberId).HasComment("會員ID");

                entity.Property(e => e.PayState).HasComment("付款狀態(1.付款完成2.付款失敗3.未付款)");

                entity.Property(e => e.PaymentId).HasComment("付款方式ID");

                entity.Property(e => e.Price).HasComment("價錢");

                entity.HasOne(d => d.CashPlan)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.CashPlanId)
                    .HasConstraintName("FK_RechargeRecord_CashPlan");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_Member");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_PayMethod");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.HasIndex(e => e.AuditEmployeeId, "IX_Report_AuditEmployeeId");

                entity.HasIndex(e => e.CommentId, "IX_Report_CommentId");

                entity.Property(e => e.ReportId).HasComment("檢舉Id");

                entity.Property(e => e.AuditEmployeeId).HasComment("審核人員");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasComment("審核時間");

                entity.Property(e => e.AuditType).HasComment("審核狀態");

                entity.Property(e => e.CommentId).HasComment("評論Id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("檢舉日期");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasComment("檢舉詳細理由");

                entity.HasOne(d => d.AuditEmployee)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.AuditEmployeeId)
                    .HasConstraintName("FK_Report_Employee");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Comment");
            });

            modelBuilder.Entity<ViewRecord>(entity =>
            {
                entity.HasKey(e => e.ViewRecorId);

                entity.ToTable("ViewRecord");

                entity.HasIndex(e => e.EpId, "IX_ViewRecord_EpContentId");

                entity.HasIndex(e => e.MemberId, "IX_ViewRecord_MemberId");

                entity.Property(e => e.EpId).HasComment("集數Id");

                entity.Property(e => e.MemberId).HasComment("會員");

                entity.Property(e => e.ViewTime)
                    .HasColumnType("datetime")
                    .HasComment("觀看時間");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.ViewRecords)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_Episode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ViewRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
