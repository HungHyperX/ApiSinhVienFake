using ApiSinhVien.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSinhVien.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().ToTable("students"); // dùng chữ thường để khớp PostgreSQL

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students"); // Tên bảng viết thường

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Uid).HasColumnName("uid");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Class).HasColumnName("class");
                entity.Property(e => e.Department).HasColumnName("department");
            });
        }
    }
}
