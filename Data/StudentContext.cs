using ApiSinhVien.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSinhVien.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
