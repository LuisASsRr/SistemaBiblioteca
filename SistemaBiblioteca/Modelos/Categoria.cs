namespace SistemaBiblioteca.Modelos
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        public string NombreCategoria { get; set; }


        public List<Libro> Libros { get; set; } = new();   }
}
