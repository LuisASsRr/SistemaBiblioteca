namespace SistemaBiblioteca.Modelos
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Edicion { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public int NumPaginas { get; set; }
        public string NumEstanteria { get; set; } = string.Empty;


        public List<Ejemplar> Ejemplares { get; set; } = new();
        public List<Categoria> Categorias { get; set; } = new();
        public List<Autor> Autores { get; set; } = new();
    }
}
