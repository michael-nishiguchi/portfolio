using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class UpdateModels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participant_Program_ProgramID",
                table: "Participant");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramID",
                table: "Participant",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_Program_ProgramID",
                table: "Participant",
                column: "ProgramID",
                principalTable: "Program",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participant_Program_ProgramID",
                table: "Participant");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramID",
                table: "Participant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_Program_ProgramID",
                table: "Participant",
                column: "ProgramID",
                principalTable: "Program",
                principalColumn: "ProgramID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
