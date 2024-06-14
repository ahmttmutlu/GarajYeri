using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarajYeri.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPhotoDes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "VehiclePhotos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "VehiclePhotos");
        }
    }
}
