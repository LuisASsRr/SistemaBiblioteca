namespace SistemaBiblioteca.Modelos
{
    public class Lector
    {
        public int LectorID { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string DNI { get; set; }

        public string? Direccion { get; set; }

        public string? CodigoEstudiante { get; set; }

        public int TipoLectorID { get; set; }
        public TipoLector TipoLector { get; set; } = null!;

        public int? EscuelaID { get; set; } 
        public EscuelaProfesional? EscuelaProfesional { get; set; } 

        public Carnet? Carnet { get; set; } 

       
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

   
        public List<Incidencia> Incidencias { get; set; } = new List<Incidencia>();

   
        public List<HemerotecaConsulta> HemerotecaConsultas { get; set; } = new List<HemerotecaConsulta>();
    }
}
