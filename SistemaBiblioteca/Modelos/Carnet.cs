namespace SistemaBiblioteca.Modelos
{
    public class Carnet
    {
        public int CarnetID { get; set; }
        public string CodigoCarnet { get; set; } = string.Empty;


        public DateTime FechaEmision { get; set; }

        public string Estado { get; set; } = string.Empty;


        public int LectorID { get; set; } 
        public Lector Lector { get; set; } = null!;
    }
}
