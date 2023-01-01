using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efc_console.Migrations
{
    public partial class Book_IEntityTypeConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Books",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 1, 15, 58, 30, 22, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookTitle" },
                values: new object[] { 1, "Ertan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookTitle" },
                values: new object[] { 2, "Yagmur" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookTitle" },
                values: new object[] { 3, "29 Yirmidokuz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
