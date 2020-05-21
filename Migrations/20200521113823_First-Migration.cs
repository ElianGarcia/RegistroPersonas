using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Cedula = table.Column<string>(maxLength: 11, nullable: false),
                    Direccion = table.Column<string>(maxLength: 40, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaID);
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaID", "Cedula", "Direccion", "FechaDeNacimiento", "Nombres", "Telefono" },
                values: new object[] { 1, "05600345926", "Calle Roberto Acevedo #34", new DateTime(2020, 5, 21, 7, 38, 23, 222, DateTimeKind.Local).AddTicks(6904), "Juan Alberto", "8292655182" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
