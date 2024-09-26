using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Repositorio.IRepositorio;

namespace ApiPeliculas.Repositorio;

public class CategoriaRepositorio : ICategoriaRepositorio
{
    private readonly ApplicationDbContext _bd;

    public CategoriaRepositorio(ApplicationDbContext bd)
    {
        _bd = bd;
    }

    public ICollection<Categoria> GetCategorias()
    {
        return _bd.Categorias.OrderBy(c => c.Nombre).ToList();
    }

    public Categoria GetCategoriaById(int id)
    {
        var categoria = _bd.Categorias.FirstOrDefault(c => c.Id == id);
        return categoria;
    }

    public bool ExisteCategoriaById(int id)
    {
        var valor =  _bd.Categorias.Any(c => c.Id == id);

        return valor;
    }

    public bool ExisteCategoriaByNombre(string name)
    {
        var valor =  _bd.Categorias.Any(c => c.Nombre.ToLower().Trim() == name.ToLower().Trim());

        return valor;
    }

    public bool CrearCategoria(Categoria categoria)
    {
        categoria.FechaCreacion = DateTime.Now;
        _bd.Categorias.Add(categoria);
        return  Guardar();
    }

    public bool ActualizarCategoria(Categoria categoria)
    {
        categoria.FechaCreacion = DateTime.Now;
        _bd.Categorias.Update(categoria);
        return  Guardar();
    }

    public bool EliminarCategoria(Categoria categoria)
    {
        _bd.Categorias.Remove(categoria);
        return  Guardar();
    }

    public bool Guardar()
    {
       return  _bd.SaveChanges() > 0;
    }
}