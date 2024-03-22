using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestRegister.Migrations
{
    /// <inheritdoc />
    public partial class award2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardPhoto",
                table: "Awards");

            migrationBuilder.AddColumn<byte[]>(
                name: "AwardPhoto1",
                table: "Awards",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "AwardPhoto2",
                table: "Awards",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardPhoto1",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "AwardPhoto2",
                table: "Awards");

            migrationBuilder.AddColumn<string>(
                name: "AwardPhoto",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
