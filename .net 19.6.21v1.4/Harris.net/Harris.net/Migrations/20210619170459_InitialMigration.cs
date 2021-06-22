using Microsoft.EntityFrameworkCore.Migrations;

namespace Harris.net.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessContacts",
                columns: table => new
                {
                    BusinessContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessContactFName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessContactPostcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessContacts", x => x.BusinessContactID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalContacts",
                columns: table => new
                {
                    PersonalContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalContactFName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactLName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactAddr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactAddr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalContactPostcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalContacts", x => x.PersonalContactID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessContacts");

            migrationBuilder.DropTable(
                name: "PersonalContacts");
        }
    }
}
