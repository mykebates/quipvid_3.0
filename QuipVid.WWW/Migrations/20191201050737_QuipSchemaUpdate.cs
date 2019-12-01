using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuipVid.WWW.Migrations
{
    public partial class QuipSchemaUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Quips");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Quips");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Quips",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Quips",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OmdbId",
                table: "Quips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Script",
                table: "Quips",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Quips",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Quips");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Quips");

            migrationBuilder.DropColumn(
                name: "OmdbId",
                table: "Quips");

            migrationBuilder.DropColumn(
                name: "Script",
                table: "Quips");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Quips");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Quips",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Views",
                table: "Quips",
                type: "text",
                nullable: true);
        }
    }
}
