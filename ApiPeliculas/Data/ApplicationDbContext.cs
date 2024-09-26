using ApiPeliculas.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data;

public class ApplicationDbContext : DbContext
{
    //ctor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    //Aqui pasar todas las entidades
    public DbSet<Categoria> Categorias { get; set; }
}