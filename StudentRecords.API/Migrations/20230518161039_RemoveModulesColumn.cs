using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRecords.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveModulesColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModulesName",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Modules",
                newName: "ModuleId");

            migrationBuilder.RenameColumn(
                name: "ModulesId",
                table: "Modules",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModuleName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModuleGrade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ModuleId",
                table: "Modules",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Module_ModuleId",
                table: "Modules",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Module_ModuleId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropIndex(
                name: "IX_Modules_ModuleId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "Modules",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modules",
                newName: "ModulesId");

            migrationBuilder.AddColumn<string>(
                name: "ModulesName",
                table: "Modules",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
