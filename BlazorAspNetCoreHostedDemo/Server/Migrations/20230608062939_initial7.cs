using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAspNetCoreHostedDemo.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserAccount",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "UserAccount",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserAccount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "Gender" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "UserAccount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "Gender" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "UserAccount",
                type: "int",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Country",
                table: "UserAccount",
                type: "int",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserAccount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "Gender" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "UserAccount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "Gender" },
                values: new object[] { null, null });
        }
    }
}
