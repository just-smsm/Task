using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp90.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaskMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "NewTask");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "NewTask",
                newName: "DeadLine");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "NewTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask");

            migrationBuilder.RenameTable(
                name: "NewTask",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "DeadLine",
                table: "Tasks",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");
        }
    }
}
