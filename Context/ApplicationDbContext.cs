using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM_NET._7.Entities;

namespace ProyectoWeb24AM_NET._7.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)  { }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Insert en la tabla usuario

            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PkRol = 1,
                    Nombre = "admin"
                },
                new Rol
                {
                    PkRol = 2,
                    Nombre = "admin"
                }
                );


            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PKUsuario = 1,
                    Nombre = "Maria Jose",
                    Apellido = "Sosa",
                    UserName = "Majo",
                    Password = "1234",
                    FkRol = 1,

                }) ;

        }
    }
}
