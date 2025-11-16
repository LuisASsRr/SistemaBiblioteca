namespace SistemaBiblioteca.Modelos
{
    public class Ejemplar
    {
        public int EjemplarID { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string? TipoAdquisicion { get; set; }


        public int LibroID { get; set; }
        public Libro Libro { get; set; } = null!;

        public List<Prestamo> Prestamos { get; set; } = new();
        public List<Incidencia> Incidencias { get; set; } = new();


    }
}
