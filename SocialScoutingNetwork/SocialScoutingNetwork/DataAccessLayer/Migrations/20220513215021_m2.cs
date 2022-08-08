using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<int>(
                name: "SkillID",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_SkillID",
                table: "Players",
                column: "SkillID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Skills_SkillID",
                table: "Players",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "SkillID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Skills_SkillID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_SkillID",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "SkillID",
                table: "Players");
        }
    }
}
