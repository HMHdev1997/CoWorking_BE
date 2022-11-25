using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoWorking.Data.Access.Data.Migrations.MsSql
{
    public partial class InitialDbMssqlv01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Offices",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Offices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Offices",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Offices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Offices");
        }
    }
}
