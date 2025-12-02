using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Modelos
{
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; } = string.Empty;

        public string Edicion { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public int Stock { get; set; }
        public int NumPaginas { get; set; }
        public string NumEstanteria { get; set; } = string.Empty;

        public string? ImagenUrl { get; set; }

        public string? ISBN { get; set; }


        public List<Autor> Autores { get; set; } = new();
        public List<Categoria> Categorias { get; set; } = new();

        public List<Ejemplar> Ejemplares { get; set; } = new();
    }
}