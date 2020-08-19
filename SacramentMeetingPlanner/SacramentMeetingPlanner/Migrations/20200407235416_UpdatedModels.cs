using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropColumn(
                name: "ClosingPrayer",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "ConductingLeader",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "OpeningPrayer",
                table: "Program");

            migrationBuilder.AddColumn<int>(
                name: "ClosingPrayerParticipantID",
                table: "Program",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConductingLeaderParticipantID",
                table: "Program",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningPrayerParticipantID",
                table: "Program",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PresidingLeaderParticipantID",
                table: "Program",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    ParticipantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullNameOfParticipant = table.Column<string>(nullable: true),
                    TalkSubject = table.Column<string>(nullable: true),
                    ParticipantTitle = table.Column<string>(nullable: true),
                    ProgramID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.ParticipantID);
                    table.ForeignKey(
                        name: "FK_Participant_Program_ProgramID",
                        column: x => x.ProgramID,
                        principalTable: "Program",
                        principalColumn: "ProgramID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Participant_ProgramID",
                table: "Participant",
                column: "ProgramID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Participant");

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
                name: "ClosingPrayer",
                table: "Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConductingLeader",
                table: "Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningPrayer",
                table: "Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullNameOfSpeaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    SpeakerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TalkSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerID);
                    table.ForeignKey(
                        name: "FK_Speaker_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "ProgramID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_ProgramId",
                table: "Speaker",
                column: "ProgramId");
        }
    }
}
