using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonApp_MVC.Migrations
{
    public partial class Add_Joueur_Equipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Equipe_Id",
                table: "Joueurs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proprietaire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Joueurs_Equipe_Id",
                table: "Joueurs",
                column: "Equipe_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Joueurs_Equipes_Equipe_Id",
                table: "Joueurs",
                column: "Equipe_Id",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joueurs_Equipes_Equipe_Id",
                table: "Joueurs");

            migrationBuilder.DropTable(
                name: "Equipes");

            migrationBuilder.DropIndex(
                name: "IX_Joueurs_Equipe_Id",
                table: "Joueurs");

            migrationBuilder.DropColumn(
                name: "Equipe_Id",
                table: "Joueurs");
        }
    }
}
