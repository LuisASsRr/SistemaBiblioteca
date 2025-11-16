namespace SistemaBiblioteca.Modelos
{
    public class Incidencia
    {
        public int IncidenciaID { get; set; }
        public string? TipoSancion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaReporte { get; set; }
        public string EstadoIncidencia { get; set; } = string.Empty;


        public int EjemplarID { get; set; } 
        public Ejemplar Ejemplar { get; set; } = null!;


        public int LectorID { get; set; } 
        public Lector Lector { get; set; } = null!; 


        public int? PrestamoID { get; set; } 
        public Prestamo? Prestamo { get; set; }

    }
}
