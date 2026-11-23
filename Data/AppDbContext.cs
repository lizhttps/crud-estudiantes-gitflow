using Microsoft.EntityFrameworkCore;
using CrudEstudiantes.Models;

namespace CrudEstudiantes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estudiante>().HasData(
                new Estudiante
                {
                    Id = 1,
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Email = "juan.perez@ejemplo.com",
                    Matricula = "2024-0001",
                    FechaRegistro = new DateTime(2024, 1, 15)
                },
                new Estudiante
                {
                    Id = 2,
                    Nombre = "María",
                    Apellido = "García",
                    Email = "maria.garcia@ejemplo.com",
                    Matricula = "2024-0002",
                    FechaRegistro = new DateTime(2024, 1, 20)
                },
                new Estudiante
                {
                    Id = 3,
                    Nombre = "Carlos",
                    Apellido = "Rodríguez",
                    Email = "carlos.rod@ejemplo.com",
                    Matricula = "2024-0003",
                    FechaRegistro = new DateTime(2024, 2, 10)
                }
            );
        }
    }
}