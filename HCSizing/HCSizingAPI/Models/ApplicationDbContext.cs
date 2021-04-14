using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedObjects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSizingAPI.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        {

        }
        public virtual DbSet<Debug> Debug { get; set; }
        public virtual DbQuery<VDebugData> VDebugData { get; set; }

        public virtual DbSet<DebugRawData> DebugRawData { get; set; }
        public virtual DbQuery<VDebugRawData> VDebugRawData { get; set; }
        public virtual DbQuery<VLoggedHC> VLoggedHC { get; set; }

        public virtual DbQuery<VDebugResult> VDebugResult { get; set; } // là model chứa kết quả
        public virtual DbQuery<VTestResult> VTestResult { get; set; } // là model chứa kết quả

        public virtual DbSet<AccessUserRole> AccessUserRole { get; set; }
        public virtual DbQuery<VAccessUserRole> VAccessUserRole { get; set; }
        public virtual DbSet<Wc> Wc { get; set; }
        public virtual DbQuery<VWC> VWC { get; set; }
        public virtual DbQuery<VStation> VStation { get; set; }
        public virtual DbQuery<VDowntime> VDowntime { get; set; }
        public virtual DbQuery<VEquipmentQuantity> VEquipmentQuantity { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbQuery<VActivities> VActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "dev02008_imic");

            modelBuilder.Entity<DebugRawData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoverRate).HasColumnName("coverRate");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShifPatten)
                    .HasColumnName("shifPatten")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoadingForDebug).HasColumnName("totalLoadingForDebug");

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("updateBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wc)
                    .HasColumnName("WC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkEfficiency).HasColumnName("workEfficiency");

                entity.Property(e => e.WorkingDayPerMonth).HasColumnName("workingDayPerMonth");

                entity.Property(e => e.WorkingHourPerShift).HasColumnName("workingHourPerShift");
            });
            modelBuilder.Entity<Wc>(entity =>
            {
                entity.ToTable("WC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Wcname)
                    .HasColumnName("WCName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Debug>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DebugHitrateYield).HasColumnName("debugHitrateYield");

                entity.Property(e => e.DebugTimeForHardcoreBoard).HasColumnName("debugTimeForHardcoreBoard");

                entity.Property(e => e.DebugTimeForNormalBoard).HasColumnName("debugTimeForNormalBoard");

                entity.Property(e => e.FinalYield).HasColumnName("finalYield");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NormalRate).HasColumnName("normalRate");

                entity.Property(e => e.Station)
                    .HasColumnName("station")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("updateBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wc)
                    .HasColumnName("WC")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Hc>(entity =>
            {
                entity.ToTable("HC");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Month)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wc)
                    .HasColumnName("WC")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AccessUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Ntlogin)
                    .HasColumnName("NTLogin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantID");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Activities>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DowntimeDetail)
                    .HasColumnName("downtimeDetail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DowntimeType)
                    .HasColumnName("downtimeType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StationOrTester)
                    .HasColumnName("stationOrTester")
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Wc)
                    .HasColumnName("wc")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8CIII70;Initial Catalog=CTTN;User Id=sa;Password=123456;MultipleActiveResultSets=true;");
            }
        }
    }
}
