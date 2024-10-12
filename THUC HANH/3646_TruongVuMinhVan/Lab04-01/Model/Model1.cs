using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab04_01.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .Property(e => e.FacultyName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.AverageScore)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student>()
                .Property(e => e.Gender)
                .IsUnicode(false);
        }
    }
}
