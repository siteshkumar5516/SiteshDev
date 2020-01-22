using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Temporaryemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PermanentEmployee",
                table: "PermanentEmployee");

            migrationBuilder.RenameTable(
                name: "PermanentEmployee",
                newName: "PermanentEmployees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermanentEmployees",
                table: "PermanentEmployees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TemporaryEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NoOfHours = table.Column<int>(nullable: false),
                    HourlyPaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryEmployees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporaryEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermanentEmployees",
                table: "PermanentEmployees");

            migrationBuilder.RenameTable(
                name: "PermanentEmployees",
                newName: "PermanentEmployee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermanentEmployee",
                table: "PermanentEmployee",
                column: "Id");
        }
    }
}
