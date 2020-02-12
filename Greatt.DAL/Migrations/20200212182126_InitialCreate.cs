using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Greatt.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroClubFFTT = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdherentEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroLicenceFFTT = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    ClubId = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    CodeOrdre = table.Column<string>(nullable: true),
                    AdresseMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdherentEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdherentEntity_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdherentEntity_ClubId",
                table: "AdherentEntity",
                column: "ClubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdherentEntity");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
