namespace SistemaBiblioteca.Modelos
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;

        public List<Libro> Libros { get; set; } = new();


        public List<HemerotecaDocumento> Documentos { get; set; } = new();
    }
}
