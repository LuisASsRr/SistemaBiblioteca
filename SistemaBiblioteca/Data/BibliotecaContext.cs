using Microsoft.EntityFrameworkCore;

using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }


        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<EscuelaProfesional> EscuelasProfesionales { get; set; }

        // --- Personas ---
        public DbSet<TipoLector> TiposLectores { get; set; }
        public DbSet<Lector> Lectores { get; set; }
        public DbSet<Bibliotecario> Bibliotecarios { get; set; }
        public DbSet<Carnet> Carnets { get; set; }

        // --- Catálogo ---
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ejemplar> Ejemplares { get; set; }

        // --- Transacciones ---
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }

        // --- Hemeroteca ---
        public DbSet<HemerotecaDocumento> HemerotecaDocumentos { get; set; }
        public DbSet<HemerotecaConsulta> HemerotecaConsultas { get; set; }

    }
}
