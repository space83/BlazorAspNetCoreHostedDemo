using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAspNetCoreHostedDemo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name", "Pictures", "Price1", "Price2" },
                values: new object[,]
                {
                    { 1, "The Mazdaspeed 3 is a sport compact hatchback introduced for the 2007 model year by Mazdaspeed and produced until 2013. The Mazdaspeed3 is a performance-enhanced version of the 5-door Mazda3. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", "Mazda 3 MPS", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkzdAyIgacPSF3KGaUTMicrAxOkVozyC8-Hw&usqp=CAU", 75888.0, 85888.0 },
                    { 2, "The Renault Mégane (French pronunciation: meɡan), also spelled without the acute accent as Megane,[1] especially in languages other than French, is a small family car produced by the French car manufacturer Renault for model year 1996, and was the successor to the Renault 19. lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", "Renault Megane RS 250 Cup", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWrOHHD-ATaYSkLdN6OxaVWQFWbdN_n-3MEw&usqp=CAU", 69800.0, 79800.0 },
                    { 3, "lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen lorem ipsum Volkswagen", "Volkswagen Golf GTI Mk6", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXbIRxw8xqxqHn0rvUx7EUsI_u4Mw2EmpZ-Q&usqp=CAU", 71800.0, 81800.0 }
                });
        }
    }
}
