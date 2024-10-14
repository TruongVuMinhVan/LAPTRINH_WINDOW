 using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De01.SQL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Lop> CacLop { get; set; }
        public virtual DbSet<Sinhvien> CacSinhvien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
