using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ASP.NET_CORE_MVC.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(100)",
                table: "Employees",
                newName: "OfficeLocation");

            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "varchar(10)",
                table: "Employees",
                newName: "EmpCode");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmpCode",
                table: "Employees",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "OfficeLocation",
                table: "Employees",
                newName: "varchar(100)");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "nvarchar(250)");

            migrationBuilder.RenameColumn(
                name: "EmpCode",
                table: "Employees",
                newName: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(100)",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(10)",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);
        }
    }
}
