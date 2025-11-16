namespace SistemaBiblioteca.Modelos
{
    public class Facultad
    {
        public int FacultadId { get; set; }
        public string Nombre { get; set; } = string.Empty;


        public List<EscuelaProfesional> EscuelasProfesionales { get; set; } = new();
    }
}

