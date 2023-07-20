using Microsoft.EntityFrameworkCore;

namespace CRUD_TEST.Models
{
    public class EstudianteContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-F7I84IVN\\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
