namespace SistemaBiblioteca.Modelos
{
    public class TipoLector
    {
        public int TipoLectorID { get; set; }

        public string NombreTipo { get; set; }

        public List<Lector> Lectores { get; set; } = new List<Lector>();
    }
}
