
using System.ComponentModel.DataAnnotations; 

namespace SistemaBiblioteca.Modelos
{
    public class HemerotecaConsulta
    {
        
        [Key] 
        public int ConsultaID { get; set; }
        public DateTime Fecha { get; set; }

        public int LectorID { get; set; }
        public Lector Lector { get; set; } = null!;

        public int DocumentoID { get; set; }
        public HemerotecaDocumento HemerotecaDocumento { get; set; } = null!;
    }
}
