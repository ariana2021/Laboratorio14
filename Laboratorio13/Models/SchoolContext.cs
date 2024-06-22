using Laboratorio13.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Models
{ 
     public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-11\\SQLEXPRESS; " +
                "Initial Catalog=DataBase; Integrated Security=True;trustservercertificate=True");
        }

        public DbSet<Laboratorio13.Models.Course> Course { get; set; } = default!;

        public DbSet<Laboratorio13.Models.Enrollment> Enrollment { get; set; } = default!;
    }

}