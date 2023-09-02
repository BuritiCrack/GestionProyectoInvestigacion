using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto2.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalAffiliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigadors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoDeInvestigacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartlDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndlDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectLeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvestigationArea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoDeInvestigacions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investigadors_Id",
                table: "Investigadors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoDeInvestigacions_Id",
                table: "ProyectoDeInvestigacions",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigadors");

            migrationBuilder.DropTable(
                name: "ProyectoDeInvestigacions");
        }
    }
}
