using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FragranceWebshop_Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perfums",
                columns: table => new
                {
                    PerfumId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PerfumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedSeason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfums", x => x.PerfumId);
                });

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PerfumId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_purchases_perfums_PerfumId",
                        column: x => x.PerfumId,
                        principalTable: "perfums",
                        principalColumn: "PerfumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_purchases_PerfumId",
                table: "purchases",
                column: "PerfumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "perfums");
        }
    }
}
