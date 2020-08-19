using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class UpdateModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_Participant_ClosingPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Participant_ConductingLeaderParticipantID",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Participant_OpeningPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Participant_PresidingLeaderParticipantID",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_ClosingPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_ConductingLeaderParticipantID",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_OpeningPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_PresidingLeaderParticipantID",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "ClosingPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "ConductingLeaderParticipantID",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "OpeningPrayerParticipantID",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "PresidingLeaderParticipantID",
                table: "Program");

            migrationBuilder.AddColumn<string>(
                name: "ParticipantRole",
                table: "Participant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticipantRole",
                table: "Participant");

            migrationBuilder.AddColumn<int>(
                name: "ClosingPrayerParticipantID",
                table: "Program",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConductingLeaderParticipantID",
                table: "Program",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningPrayerParticipantID",
                table: "Program",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PresidingLeaderParticipantID",
                table: "Program",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Program_ClosingPrayerParticipantID",
                table: "Program",
                column: "ClosingPrayerParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_Program_ConductingLeaderParticipantID",
                table: "Program",
                column: "ConductingLeaderParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_Program_OpeningPrayerParticipantID",
                table: "Program",
                column: "OpeningPrayerParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_Program_PresidingLeaderParticipantID",
                table: "Program",
                column: "PresidingLeaderParticipantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Participant_ClosingPrayerParticipantID",
                table: "Program",
                column: "ClosingPrayerParticipantID",
                principalTable: "Participant",
                principalColumn: "ParticipantID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Participant_ConductingLeaderParticipantID",
                table: "Program",
                column: "ConductingLeaderParticipantID",
                principalTable: "Participant",
                principalColumn: "ParticipantID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Participant_OpeningPrayerParticipantID",
                table: "Program",
                column: "OpeningPrayerParticipantID",
                principalTable: "Participant",
                principalColumn: "ParticipantID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Participant_PresidingLeaderParticipantID",
                table: "Program",
                column: "PresidingLeaderParticipantID",
                principalTable: "Participant",
                principalColumn: "ParticipantID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
