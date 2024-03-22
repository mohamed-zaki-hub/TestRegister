using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestRegister.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accessibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bedroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontDeskServices = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transportation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cleaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomAmenities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Media = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Safty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bathroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kitchen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NationalId2 = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "ManagerDatas");
        }
    }
}
