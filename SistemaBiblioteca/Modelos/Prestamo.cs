namespace SistemaBiblioteca.Modelos
{
    public class Prestamo
    {
        public int PrestamoID { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; } 
        public string EstadoPrestamo { get; set; } = string.Empty; 


        public List<Incidencia> Incidencias { get; set; } = new(); 


        public int BibliotecarioID { get; set; } 
        public Bibliotecario Bibliotecario { get; set; } = null!;


        public int EjemplarID { get; set; } 
        public Ejemplar Ejemplar { get; set; } = null!;

   
        public int LectorID { get; set; } 
        public Lector Lector { get; set; } = null!;
    }
}
