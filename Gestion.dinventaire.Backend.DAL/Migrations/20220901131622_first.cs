﻿using System;
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
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chaise", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Clavier",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clavier", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Computer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Table", x => x.id);
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
                    IsActif = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    clavierid = table.Column<int>(type: "int", nullable: true),
                    chaisid = table.Column<int>(type: "int", nullable: true),
                    computerid = table.Column<int>(type: "int", nullable: true),
                    tableid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                    table.CheckConstraint("checkMinLenMail", "lEN(Email)>=5");
                    table.ForeignKey(
                        name: "FK_T_Employee_T_chaise_chaisid",
                        column: x => x.chaisid,
                        principalTable: "T_chaise",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_T_Employee_T_Clavier_clavierid",
                        column: x => x.clavierid,
                        principalTable: "T_Clavier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_T_Employee_T_Computer_computerid",
                        column: x => x.computerid,
                        principalTable: "T_Computer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_T_Employee_T_Table_tableid",
                        column: x => x.tableid,
                        principalTable: "T_Table",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_chaisid",
                table: "T_Employee",
                column: "chaisid");

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_clavierid",
                table: "T_Employee",
                column: "clavierid");

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_computerid",
                table: "T_Employee",
                column: "computerid");

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_email",
                table: "T_Employee",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Employee_tableid",
                table: "T_Employee",
                column: "tableid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Employee");

            migrationBuilder.DropTable(
                name: "T_chaise");

            migrationBuilder.DropTable(
                name: "T_Clavier");

            migrationBuilder.DropTable(
                name: "T_Computer");

            migrationBuilder.DropTable(
                name: "T_Table");
        }
    }
}