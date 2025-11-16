namespace SistemaBiblioteca.Modelos
{
    public class Bibliotecario
    {
        public int BibliotecarioID { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string UsuarioBibliotecario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;


        public List<Prestamo> Prestamos { get; set; } = new();
    }
}
