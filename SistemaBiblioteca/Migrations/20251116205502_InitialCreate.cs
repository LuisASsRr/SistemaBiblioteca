using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBiblioteca.Migrations
{
    
    public partial class InitialCreate : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecarios",
                columns: table => new
                {
                    BibliotecarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioBibliotecario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecarios", x => x.BibliotecarioID);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Facultades",
                columns: table => new
                {
                    FacultadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultades", x => x.FacultadId);
                });

            migrationBuilder.CreateTable(
                name: "HemerotecaDocumentos",
                columns: table => new
                {
                    DocumentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HemerotecaDocumentos", x => x.DocumentoID);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false),
                    NumPaginas = table.Column<int>(type: "int", nullable: false),
                    NumEstanteria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroID);
                });

            migrationBuilder.CreateTable(
                name: "TiposLectores",
                columns: table => new
                {
                    TipoLectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposLectores", x => x.TipoLectorID);
                });

            migrationBuilder.CreateTable(
                name: "EscuelasProfesionales",
                columns: table => new
                {
                    EscuelaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultadID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscuelasProfesionales", x => x.EscuelaID);
                    table.ForeignKey(
                        name: "FK_EscuelasProfesionales_Facultades_FacultadID",
                        column: x => x.FacultadID,
                        principalTable: "Facultades",
                        principalColumn: "FacultadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorHemerotecaDocumento",
                columns: table => new
                {
                    AutoresAutorId = table.Column<int>(type: "int", nullable: false),
                    DocumentosDocumentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorHemerotecaDocumento", x => new { x.AutoresAutorId, x.DocumentosDocumentoID });
                    table.ForeignKey(
                        name: "FK_AutorHemerotecaDocumento_Autores_AutoresAutorId",
                        column: x => x.AutoresAutorId,
                        principalTable: "Autores",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorHemerotecaDocumento_HemerotecaDocumentos_DocumentosDocumentoID",
                        column: x => x.DocumentosDocumentoID,
                        principalTable: "HemerotecaDocumentos",
                        principalColumn: "DocumentoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    AutoresAutorId = table.Column<int>(type: "int", nullable: false),
                    LibrosLibroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLibro", x => new { x.AutoresAutorId, x.LibrosLibroID });
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autores_AutoresAutorId",
                        column: x => x.AutoresAutorId,
                        principalTable: "Autores",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libros_LibrosLibroID",
                        column: x => x.LibrosLibroID,
                        principalTable: "Libros",
                        principalColumn: "LibroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaLibro",
                columns: table => new
                {
                    CategoriasCategoriaID = table.Column<int>(type: "int", nullable: false),
                    LibrosLibroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLibro", x => new { x.CategoriasCategoriaID, x.LibrosLibroID });
                    table.ForeignKey(
                        name: "FK_CategoriaLibro_Categorias_CategoriasCategoriaID",
                        column: x => x.CategoriasCategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaLibro_Libros_LibrosLibroID",
                        column: x => x.LibrosLibroID,
                        principalTable: "Libros",
                        principalColumn: "LibroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    EjemplarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoAdquisicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.EjemplarID);
                    table.ForeignKey(
                        name: "FK_Ejemplares_Libros_LibroID",
                        column: x => x.LibroID,
                        principalTable: "Libros",
                        principalColumn: "LibroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lectores",
                columns: table => new
                {
                    LectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoLectorID = table.Column<int>(type: "int", nullable: false),
                    EscuelaID = table.Column<int>(type: "int", nullable: true),
                    EscuelaProfesionalEscuelaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectores", x => x.LectorID);
                    table.ForeignKey(
                        name: "FK_Lectores_EscuelasProfesionales_EscuelaProfesionalEscuelaID",
                        column: x => x.EscuelaProfesionalEscuelaID,
                        principalTable: "EscuelasProfesionales",
                        principalColumn: "EscuelaID");
                    table.ForeignKey(
                        name: "FK_Lectores_TiposLectores_TipoLectorID",
                        column: x => x.TipoLectorID,
                        principalTable: "TiposLectores",
                        principalColumn: "TipoLectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carnets",
                columns: table => new
                {
                    CarnetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCarnet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LectorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carnets", x => x.CarnetID);
                    table.ForeignKey(
                        name: "FK_Carnets_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HemerotecaConsultas",
                columns: table => new
                {
                    ConsultaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LectorID = table.Column<int>(type: "int", nullable: false),
                    DocumentoID = table.Column<int>(type: "int", nullable: false),
                    HemerotecaDocumentoDocumentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HemerotecaConsultas", x => x.ConsultaID);
                    table.ForeignKey(
                        name: "FK_HemerotecaConsultas_HemerotecaDocumentos_HemerotecaDocumentoDocumentoID",
                        column: x => x.HemerotecaDocumentoDocumentoID,
                        principalTable: "HemerotecaDocumentos",
                        principalColumn: "DocumentoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HemerotecaConsultas_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucionPrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucionReal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoPrestamo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BibliotecarioID = table.Column<int>(type: "int", nullable: false),
                    EjemplarID = table.Column<int>(type: "int", nullable: false),
                    LectorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoID);
                    table.ForeignKey(
                        name: "FK_Prestamos_Bibliotecarios_BibliotecarioID",
                        column: x => x.BibliotecarioID,
                        principalTable: "Bibliotecarios",
                        principalColumn: "BibliotecarioID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Ejemplares_EjemplarID",
                        column: x => x.EjemplarID,
                        principalTable: "Ejemplares",
                        principalColumn: "EjemplarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    IncidenciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSancion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaReporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoIncidencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EjemplarID = table.Column<int>(type: "int", nullable: false),
                    LectorID = table.Column<int>(type: "int", nullable: false),
                    PrestamoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.IncidenciaID);
                    table.ForeignKey(
                        name: "FK_Incidencias_Ejemplares_EjemplarID",
                        column: x => x.EjemplarID,
                        principalTable: "Ejemplares",
                        principalColumn: "EjemplarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Lectores_LectorID",
                        column: x => x.LectorID,
                        principalTable: "Lectores",
                        principalColumn: "LectorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Prestamos_PrestamoID",
                        column: x => x.PrestamoID,
                        principalTable: "Prestamos",
                        principalColumn: "PrestamoID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorHemerotecaDocumento_DocumentosDocumentoID",
                table: "AutorHemerotecaDocumento",
                column: "DocumentosDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_LibrosLibroID",
                table: "AutorLibro",
                column: "LibrosLibroID");

            migrationBuilder.CreateIndex(
                name: "IX_Carnets_LectorID",
                table: "Carnets",
                column: "LectorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaLibro_LibrosLibroID",
                table: "CategoriaLibro",
                column: "LibrosLibroID");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_LibroID",
                table: "Ejemplares",
                column: "LibroID");

            migrationBuilder.CreateIndex(
                name: "IX_EscuelasProfesionales_FacultadID",
                table: "EscuelasProfesionales",
                column: "FacultadID");

            migrationBuilder.CreateIndex(
                name: "IX_HemerotecaConsultas_HemerotecaDocumentoDocumentoID",
                table: "HemerotecaConsultas",
                column: "HemerotecaDocumentoDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_HemerotecaConsultas_LectorID",
                table: "HemerotecaConsultas",
                column: "LectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_EjemplarID",
                table: "Incidencias",
                column: "EjemplarID");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_LectorID",
                table: "Incidencias",
                column: "LectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_PrestamoID",
                table: "Incidencias",
                column: "PrestamoID");

            migrationBuilder.CreateIndex(
                name: "IX_Lectores_EscuelaProfesionalEscuelaID",
                table: "Lectores",
                column: "EscuelaProfesionalEscuelaID");

            migrationBuilder.CreateIndex(
                name: "IX_Lectores_TipoLectorID",
                table: "Lectores",
                column: "TipoLectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_BibliotecarioID",
                table: "Prestamos",
                column: "BibliotecarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EjemplarID",
                table: "Prestamos",
                column: "EjemplarID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LectorID",
                table: "Prestamos",
                column: "LectorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorHemerotecaDocumento");

            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "Carnets");

            migrationBuilder.DropTable(
                name: "CategoriaLibro");

            migrationBuilder.DropTable(
                name: "HemerotecaConsultas");

            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "HemerotecaDocumentos");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Bibliotecarios");

            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Lectores");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "EscuelasProfesionales");

            migrationBuilder.DropTable(
                name: "TiposLectores");

            migrationBuilder.DropTable(
                name: "Facultades");
        }
    }
}
