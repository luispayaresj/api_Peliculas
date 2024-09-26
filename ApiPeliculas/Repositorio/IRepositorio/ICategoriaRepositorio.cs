using ApiPeliculas.Modelos;

namespace ApiPeliculas.Repositorio.IRepositorio;

public interface ICategoriaRepositorio
{
    ICollection<Categoria> GetCategorias();
    Categoria GetCategoriaById(int id);
    bool ExisteCategoriaById(int id);
    bool ExisteCategoriaByNombre(string name);
    bool CrearCategoria(Categoria categoria);
    bool ActualizarCategoria(Categoria categoria);
    bool EliminarCategoria(Categoria categoria);
}