using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bd_Projekt.Migrations
{
    /// <inheritdoc />
    public partial class migracja13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biura",
                columns: table => new
                {
                    id_biura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biura", x => x.id_biura);
                });

            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    id_klienta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa_firmy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.id_klienta);
                });

            migrationBuilder.CreateTable(
                name: "Podwykonawcy",
                columns: table => new
                {
                    id_podwykonawcy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa_firmy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podwykonawcy", x => x.id_podwykonawcy);
                });

            migrationBuilder.CreateTable(
                name: "Dzialy",
                columns: table => new
                {
                    nazwa_dzialu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    id_biura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dzialy", x => x.nazwa_dzialu);
                    table.ForeignKey(
                        name: "FK_Dzialy_Biura_id_biura",
                        column: x => x.id_biura,
                        principalTable: "Biura",
                        principalColumn: "id_biura",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Projekty",
                columns: table => new
                {
                    id_projektu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_rozpoczecia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_klienta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekty", x => x.id_projektu);
                    table.ForeignKey(
                        name: "FK_Projekty_Klienci_id_klienta",
                        column: x => x.id_klienta,
                        principalTable: "Klienci",
                        principalColumn: "id_klienta",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Zespoly",
                columns: table => new
                {
                    id_zespolu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_powolania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_rozwiazania = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_projektu = table.Column<int>(type: "int", nullable: true),
                    id_biura = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zespoly", x => x.id_zespolu);
                    table.ForeignKey(
                        name: "FK_Zespoly_Biura_id_biura",
                        column: x => x.id_biura,
                        principalTable: "Biura",
                        principalColumn: "id_biura",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Zespoly_Projekty_id_projektu",
                        column: x => x.id_projektu,
                        principalTable: "Projekty",
                        principalColumn: "id_projektu",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    id_pracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_zatrudnienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    wyksztalcenie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pensja = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    stanowisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_zespolu = table.Column<int>(type: "int", nullable: true),
                    nazwa_dzialu = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.id_pracownika);
                    table.ForeignKey(
                        name: "FK_Pracownicy_Dzialy_nazwa_dzialu",
                        column: x => x.nazwa_dzialu,
                        principalTable: "Dzialy",
                        principalColumn: "nazwa_dzialu",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Pracownicy_Zespoly_id_zespolu",
                        column: x => x.id_zespolu,
                        principalTable: "Zespoly",
                        principalColumn: "id_zespolu",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Wspolprace",
                columns: table => new
                {
                    id_wspolpracy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_zespolu = table.Column<int>(type: "int", nullable: false),
                    id_podwykonawcy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wspolprace", x => x.id_wspolpracy);
                    table.ForeignKey(
                        name: "FK_Wspolprace_Podwykonawcy_id_podwykonawcy",
                        column: x => x.id_podwykonawcy,
                        principalTable: "Podwykonawcy",
                        principalColumn: "id_podwykonawcy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wspolprace_Zespoly_id_zespolu",
                        column: x => x.id_zespolu,
                        principalTable: "Zespoly",
                        principalColumn: "id_zespolu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dzialy_id_biura",
                table: "Dzialy",
                column: "id_biura");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownicy_id_zespolu",
                table: "Pracownicy",
                column: "id_zespolu");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownicy_nazwa_dzialu",
                table: "Pracownicy",
                column: "nazwa_dzialu");

            migrationBuilder.CreateIndex(
                name: "IX_Projekty_id_klienta",
                table: "Projekty",
                column: "id_klienta");

            migrationBuilder.CreateIndex(
                name: "IX_Wspolprace_id_podwykonawcy",
                table: "Wspolprace",
                column: "id_podwykonawcy");

            migrationBuilder.CreateIndex(
                name: "IX_Wspolprace_id_zespolu",
                table: "Wspolprace",
                column: "id_zespolu");

            migrationBuilder.CreateIndex(
                name: "IX_Zespoly_id_biura",
                table: "Zespoly",
                column: "id_biura");

            migrationBuilder.CreateIndex(
                name: "IX_Zespoly_id_projektu",
                table: "Zespoly",
                column: "id_projektu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pracownicy");

            migrationBuilder.DropTable(
                name: "Wspolprace");

            migrationBuilder.DropTable(
                name: "Dzialy");

            migrationBuilder.DropTable(
                name: "Podwykonawcy");

            migrationBuilder.DropTable(
                name: "Zespoly");

            migrationBuilder.DropTable(
                name: "Biura");

            migrationBuilder.DropTable(
                name: "Projekty");

            migrationBuilder.DropTable(
                name: "Klienci");
        }
    }
}
