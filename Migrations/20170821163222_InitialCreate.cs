using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WheatherToDatabaseConverter.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WheatherRecords",
                columns: table => new
                {
                    WheatherModelId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DBT = table.Column<float>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    E_30 = table.Column<float>(nullable: false),
                    E_45 = table.Column<float>(nullable: false),
                    E_60 = table.Column<float>(nullable: false),
                    E_90 = table.Column<float>(nullable: false),
                    HR = table.Column<float>(nullable: false),
                    Hour = table.Column<int>(nullable: false),
                    IDH = table.Column<float>(nullable: false),
                    ISH = table.Column<float>(nullable: false),
                    ITH = table.Column<float>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    NE_30 = table.Column<float>(nullable: false),
                    NE_45 = table.Column<float>(nullable: false),
                    NE_60 = table.Column<float>(nullable: false),
                    NE_90 = table.Column<float>(nullable: false),
                    NW_30 = table.Column<float>(nullable: false),
                    NW_45 = table.Column<float>(nullable: false),
                    NW_60 = table.Column<float>(nullable: false),
                    NW_90 = table.Column<float>(nullable: false),
                    N_0 = table.Column<float>(nullable: false),
                    N_30 = table.Column<float>(nullable: false),
                    N_45 = table.Column<float>(nullable: false),
                    N_60 = table.Column<float>(nullable: false),
                    N_90 = table.Column<float>(nullable: false),
                    RH = table.Column<int>(nullable: false),
                    SE_30 = table.Column<float>(nullable: false),
                    SE_45 = table.Column<float>(nullable: false),
                    SE_60 = table.Column<float>(nullable: false),
                    SE_90 = table.Column<float>(nullable: false),
                    SW_30 = table.Column<float>(nullable: false),
                    SW_45 = table.Column<float>(nullable: false),
                    SW_60 = table.Column<float>(nullable: false),
                    SW_90 = table.Column<float>(nullable: false),
                    S_30 = table.Column<float>(nullable: false),
                    S_45 = table.Column<float>(nullable: false),
                    S_60 = table.Column<float>(nullable: false),
                    S_90 = table.Column<float>(nullable: false),
                    TSKY = table.Column<float>(nullable: false),
                    WD = table.Column<float>(nullable: false),
                    WS = table.Column<float>(nullable: false),
                    W_30 = table.Column<float>(nullable: false),
                    W_45 = table.Column<float>(nullable: false),
                    W_60 = table.Column<float>(nullable: false),
                    W_90 = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheatherRecords", x => x.WheatherModelId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionModelId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegionLatitude = table.Column<float>(nullable: false),
                    RegionLongitude = table.Column<float>(nullable: false),
                    WheatherModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionModelId);
                    table.ForeignKey(
                        name: "FK_Regions_WheatherRecords_WheatherModelId",
                        column: x => x.WheatherModelId,
                        principalTable: "WheatherRecords",
                        principalColumn: "WheatherModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_WheatherModelId",
                table: "Regions",
                column: "WheatherModelId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "WheatherRecords");
        }
    }
}
