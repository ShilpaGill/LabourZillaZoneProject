using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LabourZillaZone.Models
{
    public partial class LabourZillaContext : DbContext
    {
        public LabourZillaContext()
        {
        }

        public LabourZillaContext(DbContextOptions<LabourZillaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Labour> Labour { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:labourzillazone.database.windows.net,1433;Initial Catalog=LabourZilla;Persist Security Info=False;User ID=labourzilla;Password=labour@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__Admin__4DDA2818F7A035F0");

                entity.Property(e => e.LoginId).HasMaxLength(100);

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Apassword)
                    .IsRequired()
                    .HasColumnName("APassword")
                    .HasMaxLength(50);

                entity.Property(e => e.Capassword)
                    .IsRequired()
                    .HasColumnName("CAPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.MailId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoleL)
                    .HasColumnName("Role_l")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Labour>(entity =>
            {
                entity.ToTable("labour");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(100);

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CityAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Cnfrmpswd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcontact)
                    .IsRequired()
                    .HasColumnName("LContact")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ppic)
                    .HasColumnName("PPic")
                    .HasMaxLength(100);

                entity.Property(e => e.Profession)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pswd)
                    .IsRequired()
                    .HasColumnName("pswd")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleL)
                    .HasColumnName("Role_l")
                    .HasMaxLength(50);

                entity.Property(e => e.StateL)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.Temail)
                    .HasName("PK__Test__BF03DAA6E16A412E");

                entity.Property(e => e.Temail).HasMaxLength(50);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasColumnName("TName")
                    .HasMaxLength(50);

                entity.Property(e => e.TprojectName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C018BBA51");

                entity.Property(e => e.UserId).HasMaxLength(100);

                entity.Property(e => e.CityAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasColumnName("Confirm_password")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Lcontact)
                    .IsRequired()
                    .HasColumnName("LContact")
                    .HasMaxLength(10);

                entity.Property(e => e.PasswordC)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoleL)
                    .HasColumnName("Role_l")
                    .HasMaxLength(50);

                entity.Property(e => e.StateC)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
