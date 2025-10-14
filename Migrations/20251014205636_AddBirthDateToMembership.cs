using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubPractice.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDateToMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Memberships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2000, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1999, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Memberships");
        }
    }
}
