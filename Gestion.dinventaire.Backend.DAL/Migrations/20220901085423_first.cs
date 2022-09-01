using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.dinventaire.Backend.DAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_chaise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chaise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Computer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActif = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                    table.CheckConstraint("checkMinLenMail", "lEN(Email)>=5");
                });

            migrationBuilder.CreateTable(
                name: "T_Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Clavier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clavier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Clavier_T_Employee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "T_Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Clavier_employeeId",
                table: "T_Clavier",
                column: "employeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_email",
                table: "T_Employee",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_chaise");

            migrationBuilder.DropTable(
                name: "T_Clavier");

            migrationBuilder.DropTable(
                name: "T_Computer");

            migrationBuilder.DropTable(
                name: "T_Table");

            migrationBuilder.DropTable(
                name: "T_Employee");
        }
    }
}
