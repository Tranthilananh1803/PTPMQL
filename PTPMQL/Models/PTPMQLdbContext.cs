using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class PTPMQLdbContext : DbContext
    {
        public PTPMQLdbContext()
            : base("name=PTPMQLdbContext")
        {
        }

     
        public virtual DbSet<Chitietdonhang> Chitietdonhang { get; set; }
        public virtual DbSet<Danhmuchang> Danhmuchang { get; set; }
        public virtual DbSet<Donhang> Donhang { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
       
        public virtual DbSet<Nhomhang> Nhomhang { get; set; }
        
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
               .Property(e => e.Ten)
                .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
               .Property(e => e.Hodem)
                .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
               .Property(e => e.Diachi)
                .IsUnicode(false);
            modelBuilder.Entity<Khachhang>()
               .Property(e => e.Sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietdonhang>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Chitietdonhang>()
                .Property(e => e.Thanhtien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Danhmuchang>()
                .Property(e => e.Dongia)
                .HasPrecision(19, 4);

          
        }
    }
}
