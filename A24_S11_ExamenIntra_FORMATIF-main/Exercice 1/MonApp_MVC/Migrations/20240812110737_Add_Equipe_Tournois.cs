using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonApp_MVC.Migrations
{
    public partial class Add_Equipe_Tournois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tournois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipesTournois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipe_Id = table.Column<int>(type: "int", nullable: false),
                    Tournois_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipesTournois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipesTournois_Equipes_Equipe_Id",
                        column: x => x.Equipe_Id,
                        principalTable: "Equipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipesTournois_Tournois_Tournois_Id",
                        column: x => x.Tournois_Id,
                        principalTable: "Tournois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipesTournois_Equipe_Id",
                table: "EquipesTournois",
                column: "Equipe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EquipesTournois_Tournois_Id",
                table: "EquipesTournois",
                column: "Tournois_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipesTournois");

            migrationBuilder.DropTable(
                name: "Tournois");
        }
    }
}
