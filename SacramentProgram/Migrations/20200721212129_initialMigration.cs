using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentProgram.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BroOrSis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PageNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MusicalNum",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SongID = table.Column<int>(nullable: true),
                    Performer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicalNum", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MusicalNum_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    WardName = table.Column<string>(nullable: true),
                    ConductingID = table.Column<int>(nullable: false),
                    PresidingID = table.Column<int>(nullable: false),
                    AccompanimentID = table.Column<int>(nullable: false),
                    LeadingMusicID = table.Column<int>(nullable: false),
                    OpeningSongID = table.Column<int>(nullable: false),
                    OpeningPrayerID = table.Column<int>(nullable: false),
                    SacramentSongID = table.Column<int>(nullable: false),
                    MusicalNumberID = table.Column<int>(nullable: true),
                    IntermediateSongID = table.Column<int>(nullable: false),
                    ClosingSongID = table.Column<int>(nullable: false),
                    ClosingPrayerIdID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_AccompanimentID",
                        column: x => x.AccompanimentID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_ClosingPrayerIdID",
                        column: x => x.ClosingPrayerIdID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Song_ClosingSongID",
                        column: x => x.ClosingSongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_ConductingID",
                        column: x => x.ConductingID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Song_IntermediateSongID",
                        column: x => x.IntermediateSongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_LeadingMusicID",
                        column: x => x.LeadingMusicID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_MusicalNum_MusicalNumberID",
                        column: x => x.MusicalNumberID,
                        principalTable: "MusicalNum",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_OpeningPrayerID",
                        column: x => x.OpeningPrayerID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Song_OpeningSongID",
                        column: x => x.OpeningSongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Person_PresidingID",
                        column: x => x.PresidingID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meeting_Song_SacramentSongID",
                        column: x => x.SacramentSongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonID = table.Column<int>(nullable: true),
                    MeetingID = table.Column<int>(nullable: true),
                    Topic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Speaker_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_AccompanimentID",
                table: "Meeting",
                column: "AccompanimentID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_ClosingPrayerIdID",
                table: "Meeting",
                column: "ClosingPrayerIdID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_ClosingSongID",
                table: "Meeting",
                column: "ClosingSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_ConductingID",
                table: "Meeting",
                column: "ConductingID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_IntermediateSongID",
                table: "Meeting",
                column: "IntermediateSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_LeadingMusicID",
                table: "Meeting",
                column: "LeadingMusicID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_MusicalNumberID",
                table: "Meeting",
                column: "MusicalNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_OpeningPrayerID",
                table: "Meeting",
                column: "OpeningPrayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_OpeningSongID",
                table: "Meeting",
                column: "OpeningSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_PresidingID",
                table: "Meeting",
                column: "PresidingID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SacramentSongID",
                table: "Meeting",
                column: "SacramentSongID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicalNum_SongID",
                table: "MusicalNum",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingID",
                table: "Speaker",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_PersonID",
                table: "Speaker",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "MusicalNum");

            migrationBuilder.DropTable(
                name: "Song");
        }
    }
}
