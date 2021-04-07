using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyPhongKham1.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<MedicineType> MedicineType { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<PrescriptionDetails> PrescriptionDetails { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StatusPrescription> StatusPrescription { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasOptional(e => e.Staff)
                .WithRequired(e => e.AspNetUsers);

            modelBuilder.Entity<AspNetUsers>()
                .HasOptional(e => e.Staff1)
                .WithRequired(e => e.AspNetUsers1);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Prescription)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.IDCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.PrescriptionDetails)
                .WithRequired(e => e.Medicine)
                .HasForeignKey(e => e.IDMedicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicineType>()
                .HasMany(e => e.Medicine)
                .WithRequired(e => e.MedicineType)
                .HasForeignKey(e => e.IDMedicineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicineType>()
                .HasMany(e => e.Medicine1)
                .WithRequired(e => e.MedicineType1)
                .HasForeignKey(e => e.IDMedicineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicineType>()
                .HasMany(e => e.Medicine2)
                .WithRequired(e => e.MedicineType2)
                .HasForeignKey(e => e.IDMedicineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicineType>()
                .HasMany(e => e.Medicine3)
                .WithRequired(e => e.MedicineType3)
                .HasForeignKey(e => e.IDMedicineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicineType>()
                .HasMany(e => e.Medicine4)
                .WithRequired(e => e.MedicineType4)
                .HasForeignKey(e => e.IDMedicineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prescription>()
                .HasOptional(e => e.PrescriptionDetails)
                .WithRequired(e => e.Prescription);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Prescription)
                .WithRequired(e => e.Staff)
                .HasForeignKey(e => e.StaffSetUp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusPrescription>()
                .HasMany(e => e.Prescription)
                .WithRequired(e => e.StatusPrescription)
                .HasForeignKey(e => e.IDStatusPrescription)
                .WillCascadeOnDelete(false);
        }
    }
}
