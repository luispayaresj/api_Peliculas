using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos;

public class CategoriaDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El Nombre es Obligatorio")]
    [MaxLength(100, ErrorMessage = "El numero maximo de caracteres para el nombre es de 100")]
    public string Nombre { get; set; }
    public DateTime FechaCreacion { get; set; }
}