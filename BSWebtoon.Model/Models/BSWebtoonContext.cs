using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class BSWebtoonContext : DbContext
    {
        public BSWebtoonContext()
        {
        }

        public BSWebtoonContext(DbContextOptions<BSWebtoonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditType> AuditTypes { get; set; }
        public virtual DbSet<CashPlan> CashPlans { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<ComicPic> ComicPics { get; set; }
        public virtual DbSet<ComicStatus> ComicStatuses { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CouponStock> CouponStocks { get; set; }
        public virtual DbSet<Epsiode> Epsiodes { get; set; }
        public virtual DbSet<GetTicketMethod> GetTicketMethods { get; set; }
        public virtual DbSet<KeywordConnect> KeywordConnects { get; set; }
        public virtual DbSet<KeywordDetail> KeywordDetails { get; set; }
        public virtual DbSet<LoginType> LoginTypes { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MyLove> MyLoves { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PayMethod> PayMethods { get; set; }
        public virtual DbSet<RechargeRecord> RechargeRecords { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportReason> ReportReasons { get; set; }
        public virtual DbSet<UseRecord> UseRecords { get; set; }
        public virtual DbSet<ViewRecord> ViewRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=BSWebtoon;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AuditType>(entity =>
            {
                entity.ToTable("AuditType");

                entity.Property(e => e.AuditTypeId).HasComment("審核類型");
            });

            modelBuilder.Entity<CashPlan>(entity =>
            {
                entity.ToTable("CashPlan");

                entity.Property(e => e.CashPlanName).IsRequired();

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<Comic>(entity =>
            {
                entity.ToTable("Comic");

                entity.Property(e => e.Author).IsRequired();

                entity.Property(e => e.ComicName).IsRequired();

                entity.Property(e => e.Introduction).IsRequired();

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Publisher).IsRequired();

                entity.HasOne(d => d.AuditType)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.AuditTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comic_ComicCheckType");

                entity.HasOne(d => d.ComicStatus)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.ComicStatusId)
                    .HasConstraintName("FK_Comic_ComicStatus");
            });

            modelBuilder.Entity<ComicPic>(entity =>
            {
                entity.ToTable("ComicPic");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.ComicPics)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicPic_Comic");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.ComicPics)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicPic_Epsiode");
            });

            modelBuilder.Entity<ComicStatus>(entity =>
            {
                entity.ToTable("ComicStatus");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentId).ValueGeneratedNever();

                entity.Property(e => e.CommentContext).IsRequired();

                entity.Property(e => e.CommentTime).HasColumnType("datetime");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Comic");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Epsiode");

                entity.HasOne(d => d.ReplyToComment)
                    .WithMany(p => p.InverseReplyToComment)
                    .HasForeignKey(d => d.ReplyToCommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Comment");
            });

            modelBuilder.Entity<CouponStock>(entity =>
            {
                entity.ToTable("CouponStock");

                entity.Property(e => e.CouponStockId)
                    .ValueGeneratedNever()
                    .HasComment("劵庫存量");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.CouponStocks)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.CouponStocks)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_Member");
            });

            modelBuilder.Entity<Epsiode>(entity =>
            {
                entity.HasKey(e => e.EpId);

                entity.ToTable("Epsiode");

                entity.Property(e => e.EpTitle).IsRequired();

                entity.Property(e => e.UpdateDate).IsRequired();

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Epsiodes)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Epsiode_Comic");
            });

            modelBuilder.Entity<GetTicketMethod>(entity =>
            {
                entity.ToTable("GetTicketMethod");

                entity.Property(e => e.GetTicketMethodEndDate).HasColumnType("datetime");

                entity.Property(e => e.GetTicketMethodStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.GetTicketMethods)
                    .HasForeignKey(d => d.ComicId)
                    .HasConstraintName("FK_GetMethod_Comic");
            });

            modelBuilder.Entity<KeywordConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KeywordConnect");

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keyword_Comic");

                entity.HasOne(d => d.KeywordDetail)
                    .WithMany()
                    .HasForeignKey(d => d.KeywordDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keyword_KeywordDetail");
            });

            modelBuilder.Entity<KeywordDetail>(entity =>
            {
                entity.ToTable("KeywordDetail");
            });

            modelBuilder.Entity<LoginType>(entity =>
            {
                entity.ToTable("LoginType");

                entity.Property(e => e.LoginTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasComment("餘額");

                entity.Property(e => e.LoginTypeId).HasComment("登入型態");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Setting).HasComment("設定");

                entity.HasOne(d => d.LoginType)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.LoginTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_LoginType");
            });

            modelBuilder.Entity<MyLove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MyLove");

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany()
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Member");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Member");
            });

            modelBuilder.Entity<PayMethod>(entity =>
            {
                entity.ToTable("PayMethod");

                entity.Property(e => e.PayMethodName).IsRequired();
            });

            modelBuilder.Entity<RechargeRecord>(entity =>
            {
                entity.ToTable("RechargeRecord");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CashPlan)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.CashPlanId)
                    .HasConstraintName("FK_Recharge_Coin");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_Member");

                entity.HasOne(d => d.PayMethod)
                    .WithMany(p => p.RechargeRecords)
                    .HasForeignKey(d => d.PayMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_PayMethod");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.ReportId).ValueGeneratedNever();

                entity.HasOne(d => d.BeReportedMember)
                    .WithMany(p => p.ReportBeReportedMembers)
                    .HasForeignKey(d => d.BeReportedMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Member");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Comment");

                entity.HasOne(d => d.ReportMember)
                    .WithMany(p => p.ReportReportMembers)
                    .HasForeignKey(d => d.ReportMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Member1");

                entity.HasOne(d => d.ReportReason)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReportReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_ReportReason");
            });

            modelBuilder.Entity<ReportReason>(entity =>
            {
                entity.ToTable("ReportReason");

                entity.Property(e => e.ReportReasonId).ValueGeneratedNever();
            });

            modelBuilder.Entity<UseRecord>(entity =>
            {
                entity.ToTable("UseRecord");

                entity.Property(e => e.UseDateEnd).HasColumnType("datetime");

                entity.Property(e => e.UseDateSart).HasColumnType("datetime");

                entity.HasOne(d => d.CouponStock)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.CouponStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Stocks");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Member");
            });

            modelBuilder.Entity<ViewRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViewRecord");

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_Comic");

                entity.HasOne(d => d.ComicPic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicPicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_ComicPic");

                entity.HasOne(d => d.Ep)
                    .WithMany()
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany()
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ViewRecord_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
