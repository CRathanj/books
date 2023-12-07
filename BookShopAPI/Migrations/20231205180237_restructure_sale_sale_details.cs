using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class restructuresalesaledetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "sales");

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "sale_details",
                type: "DECIMAL(15,3)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "sale_details");

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "sales",
                type: "DECIMAL(15,3)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
