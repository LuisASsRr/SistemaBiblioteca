namespace SistemaBiblioteca.Modelos
{
    public class Autor
    {
        public int AutorId { get; set; }

        public string Nombres { get; set; } = string.Empty;  
        public string Apellidos { get; set; } = string.Empty;

     
        public string? Nacionalidad { get; set; }         
      
        public List<Libro> Libros { get; set; } = new();
        public List<HemerotecaDocumento> Documentos { get; set; } = new();
    }
}
