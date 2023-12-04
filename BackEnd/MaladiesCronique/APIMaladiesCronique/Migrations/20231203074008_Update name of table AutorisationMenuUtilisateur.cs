using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIMaladiesCronique.Migrations
{
    /// <inheritdoc />
    public partial class UpdatenameoftableAutorisationMenuUtilisateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GetAutorisationMenuUtilisateurs_Menus_MenuId",
                table: "GetAutorisationMenuUtilisateurs");

            migrationBuilder.DropForeignKey(
                name: "FK_GetAutorisationMenuUtilisateurs_Utilisateurs_UtilisateurId",
                table: "GetAutorisationMenuUtilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GetAutorisationMenuUtilisateurs",
                table: "GetAutorisationMenuUtilisateurs");

            migrationBuilder.RenameTable(
                name: "GetAutorisationMenuUtilisateurs",
                newName: "AutorisationMenuUtilisateurs");

            migrationBuilder.RenameIndex(
                name: "IX_GetAutorisationMenuUtilisateurs_UtilisateurId",
                table: "AutorisationMenuUtilisateurs",
                newName: "IX_AutorisationMenuUtilisateurs_UtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_GetAutorisationMenuUtilisateurs_MenuId",
                table: "AutorisationMenuUtilisateurs",
                newName: "IX_AutorisationMenuUtilisateurs_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorisationMenuUtilisateurs",
                table: "AutorisationMenuUtilisateurs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorisationMenuUtilisateurs_Menus_MenuId",
                table: "AutorisationMenuUtilisateurs",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorisationMenuUtilisateurs_Utilisateurs_UtilisateurId",
                table: "AutorisationMenuUtilisateurs",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorisationMenuUtilisateurs_Menus_MenuId",
                table: "AutorisationMenuUtilisateurs");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorisationMenuUtilisateurs_Utilisateurs_UtilisateurId",
                table: "AutorisationMenuUtilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorisationMenuUtilisateurs",
                table: "AutorisationMenuUtilisateurs");

            migrationBuilder.RenameTable(
                name: "AutorisationMenuUtilisateurs",
                newName: "GetAutorisationMenuUtilisateurs");

            migrationBuilder.RenameIndex(
                name: "IX_AutorisationMenuUtilisateurs_UtilisateurId",
                table: "GetAutorisationMenuUtilisateurs",
                newName: "IX_GetAutorisationMenuUtilisateurs_UtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_AutorisationMenuUtilisateurs_MenuId",
                table: "GetAutorisationMenuUtilisateurs",
                newName: "IX_GetAutorisationMenuUtilisateurs_MenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetAutorisationMenuUtilisateurs",
                table: "GetAutorisationMenuUtilisateurs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GetAutorisationMenuUtilisateurs_Menus_MenuId",
                table: "GetAutorisationMenuUtilisateurs",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GetAutorisationMenuUtilisateurs_Utilisateurs_UtilisateurId",
                table: "GetAutorisationMenuUtilisateurs",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
