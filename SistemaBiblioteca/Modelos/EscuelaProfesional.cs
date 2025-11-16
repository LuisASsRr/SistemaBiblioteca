using System.Globalization;

using System.ComponentModel.DataAnnotations; 

namespace SistemaBiblioteca.Modelos
{
    public class EscuelaProfesional
    {
        
        [Key] 
        public int EscuelaID { get; set; }

        public string Nombre { get; set; } = string.Empty; 

        public int FacultadID { get; set; }
        public Facultad Facultad { get; set; } = null!;
    }
}



