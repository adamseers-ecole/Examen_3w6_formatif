using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonApp_MVC.Migrations
{
    /// <inheritdoc />
    public partial class PremiereMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FicheOfficielles_Joueurs_Joueur_Id",
                table: "FicheOfficielles");

            migrationBuilder.DropForeignKey(
                name: "FK_Joueurs_Equipes_Equipe_Id",
                table: "Joueurs");

            migrationBuilder.DropTable(
                name: "EquipesTournois");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FicheOfficielles",
                table: "FicheOfficielles");

            migrationBuilder.RenameTable(
                name: "FicheOfficielles",
                newName: "FichesOfficielles");

            migrationBuilder.RenameColumn(
                name: "Equipe_Id",
                table: "Joueurs",
                newName: "EquipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Joueurs_Equipe_Id",
                table: "Joueurs",
                newName: "IX_Joueurs_EquipeId");

            migrationBuilder.RenameColumn(
                name: "Joueur_Id",
                table: "FichesOfficielles",
                newName: "JoueurId");

            migrationBuilder.RenameIndex(
                name: "IX_FicheOfficielles_Joueur_Id",
                table: "FichesOfficielles",
                newName: "IX_FichesOfficielles_JoueurId");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Tournois",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Joueurs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Joueurs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Joueurs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Proprietaire",
                table: "Equipes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Equipes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FichesOfficielles",
                table: "FichesOfficielles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EquipeTournois",
                columns: table => new
                {
                    EquipesId = table.Column<int>(type: "int", nullable: false),
                    TournoisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipeTournois", x => new { x.EquipesId, x.TournoisId });
                    table.ForeignKey(
                        name: "FK_EquipeTournois_Equipes_EquipesId",
                        column: x => x.EquipesId,
                        principalTable: "Equipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipeTournois_Tournois_TournoisId",
                        column: x => x.TournoisId,
                        principalTable: "Tournois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipeTournois_TournoisId",
                table: "EquipeTournois",
                column: "TournoisId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichesOfficielles_Joueurs_JoueurId",
                table: "FichesOfficielles",
                column: "JoueurId",
                principalTable: "Joueurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Joueurs_Equipes_EquipeId",
                table: "Joueurs",
                column: "EquipeId",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichesOfficielles_Joueurs_JoueurId",
                table: "FichesOfficielles");

            migrationBuilder.DropForeignKey(
                name: "FK_Joueurs_Equipes_EquipeId",
                table: "Joueurs");

            migrationBuilder.DropTable(
                name: "EquipeTournois");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FichesOfficielles",
                table: "FichesOfficielles");

            migrationBuilder.RenameTable(
                name: "FichesOfficielles",
                newName: "FicheOfficielles");

            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "Joueurs",
                newName: "Equipe_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Joueurs_EquipeId",
                table: "Joueurs",
                newName: "IX_Joueurs_Equipe_Id");

            migrationBuilder.RenameColumn(
                name: "JoueurId",
                table: "FicheOfficielles",
                newName: "Joueur_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FichesOfficielles_JoueurId",
                table: "FicheOfficielles",
                newName: "IX_FicheOfficielles_Joueur_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Tournois",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Joueurs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Joueurs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Joueurs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Proprietaire",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FicheOfficielles",
                table: "FicheOfficielles",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_FicheOfficielles_Joueurs_Joueur_Id",
                table: "FicheOfficielles",
                column: "Joueur_Id",
                principalTable: "Joueurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Joueurs_Equipes_Equipe_Id",
                table: "Joueurs",
                column: "Equipe_Id",
                principalTable: "Equipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
