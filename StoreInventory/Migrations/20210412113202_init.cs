using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreInventory.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesTypes",
                columns: table => new
                {
                    ClothesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesTypes", x => x.ClothesTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    ClothesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClothesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.ClothesID);
                    table.ForeignKey(
                        name: "FK_Clothes_ClothesTypes_ClothesTypeID",
                        column: x => x.ClothesTypeID,
                        principalTable: "ClothesTypes",
                        principalColumn: "ClothesTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clothes_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClothesTypeGender",
                columns: table => new
                {
                    ClothesTypesClothesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GendersGenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesTypeGender", x => new { x.ClothesTypesClothesTypeID, x.GendersGenderID });
                    table.ForeignKey(
                        name: "FK_ClothesTypeGender_ClothesTypes_ClothesTypesClothesTypeID",
                        column: x => x.ClothesTypesClothesTypeID,
                        principalTable: "ClothesTypes",
                        principalColumn: "ClothesTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothesTypeGender_Genders_GendersGenderID",
                        column: x => x.GendersGenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ClothesTypeID",
                table: "Clothes",
                column: "ClothesTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_GenderID",
                table: "Clothes",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesTypeGender_GendersGenderID",
                table: "ClothesTypeGender",
                column: "GendersGenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "ClothesTypeGender");

            migrationBuilder.DropTable(
                name: "ClothesTypes");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
