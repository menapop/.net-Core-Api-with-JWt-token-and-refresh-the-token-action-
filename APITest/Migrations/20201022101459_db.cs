using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITest.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "firstName", "lastName" },
                values: new object[,]
                {
                    { 1, "mena", "morcos" },
                    { 2, "Ahmed ", "mohamed" },
                    { 3, "fady ", "talat" },
                    { 4, "mina", "naser" },
                    { 5, "Ahmed", "gad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
