using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_TEST.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(30)", nullable: false),
                    apellido = table.Column<string>(type: "varchar(30)", nullable: false),
                    promedio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}
