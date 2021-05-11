using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedObjects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSAPI.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        {

        }
        public virtual DbSet<AccessUserRole> AccessUserRole { get; set; }
        public virtual DbQuery<VUsers> VUsers { get; set; }
        public virtual DbQuery<VRole> VRole { get; set; }
        public virtual DbQuery<VCustomer> VCustomer { get; set; }
        public virtual DbQuery<VShift> VShifts { get; set; }
        public virtual DbQuery<VAccessUserRole> VAccessUserRole { get; set; }
        public virtual DbQuery<VRawData> VRawData { get; set; }
        public virtual DbQuery<VDebugData> VDebugData { get; set; }
        public virtual DbQuery<VDebugResult> VDebugResult { get; set; }
        public virtual DbQuery<VStation> VStation { get; set; }
        public virtual DbQuery<VEquipmentQuantity> VEquipmentQuantity { get; set; }
        public virtual DbQuery<VActivities> VActivities { get; set; }

        public virtual DbQuery<VDowntime> VDowntime { get; set; }
        public virtual DbQuery<VTestResult> VTestResult { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "dev02008_imic");

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
