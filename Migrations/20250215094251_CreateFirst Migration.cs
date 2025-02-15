using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore01.Migrations
{
    /// <inheritdoc />
    public partial class CreateFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Empoylee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 12, 42, 50, 912, DateTimeKind.Local).AddTicks(567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 41, 4, 880, DateTimeKind.Local).AddTicks(4214));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Empoylee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 41, 4, 880, DateTimeKind.Local).AddTicks(4214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 12, 42, 50, 912, DateTimeKind.Local).AddTicks(567));
        }
    }
}
