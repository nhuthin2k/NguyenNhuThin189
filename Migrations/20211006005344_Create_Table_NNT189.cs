using Microsoft.EntityFrameworkCore.Migrations;

namespace nguyennhuthin189.Migrations
{
    public partial class Create_Table_NNT189 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NNT0189",
                columns: table => new
                {
                    NNTId = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NNTName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NNTGender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNT0189", x => x.NNTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NNT0189");
        }
    }
}
