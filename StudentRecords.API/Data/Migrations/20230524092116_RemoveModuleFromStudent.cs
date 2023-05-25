using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRecords.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveModuleFromStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Module_ModuleId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ModuleId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ModuleId",
                table: "Students",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Module_ModuleId",
                table: "Students",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
