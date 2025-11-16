
using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic; 

namespace SistemaBiblioteca.Modelos
{
    public class HemerotecaDocumento
    {
        
        [Key] 
        public int DocumentoID { get; set; }

        public string? Codigo { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;

        public List<HemerotecaConsulta> HemerotecaConsultas { get; set; } = new();
        public List<Autor> Autores { get; set; } = new();
    }
}