using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoWorking.Data.Access.Data.Migrations.MsSql
{
    public partial class InitialDbMssqlv02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CategorySpace",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CategorySpace",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CategorySpace",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CategorySpace",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CategoryOffice",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CategoryOffice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CategoryOffice",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CategoryOffice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Area",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Area",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Area",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Area",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CategorySpace");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CategorySpace");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CategorySpace");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CategorySpace");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CategoryOffice");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CategoryOffice");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CategoryOffice");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CategoryOffice");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Area");
        }
    }
}
