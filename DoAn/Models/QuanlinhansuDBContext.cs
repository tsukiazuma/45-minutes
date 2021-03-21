using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Models
{
    public partial class QuanlinhansuDBContext : DbContext
    {
        public QuanlinhansuDBContext()
            : base("name=QuanlinhansuDBContext")
        {
        }

        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<DUAN> DUANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.id_Nv)
                .IsFixedLength();

            modelBuilder.Entity<DUAN>()
                .Property(e => e.id_Da)
                .IsFixedLength();

            modelBuilder.Entity<DUAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.DUAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.id_Nv)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.id_Pb)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.id_Da)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DANGNHAPs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.id_Pb)
                .IsFixedLength();

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);
        }
    }
}
