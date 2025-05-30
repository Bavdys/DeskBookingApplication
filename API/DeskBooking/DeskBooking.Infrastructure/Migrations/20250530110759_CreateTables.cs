using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeskBooking.Infrastructure.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capacity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workspace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsAirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    IsGameRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsWiFi = table.Column<bool>(type: "bit", nullable: false),
                    IsCoffee = table.Column<bool>(type: "bit", nullable: false),
                    IsMicrophones = table.Column<bool>(type: "bit", nullable: false),
                    IsHeadphones = table.Column<bool>(type: "bit", nullable: false),
                    BookingTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workspace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workspace_BookingType_BookingTypeId",
                        column: x => x.BookingTypeId,
                        principalTable: "BookingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkspaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Workspace_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkspaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Workspace_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkspaceCapacity",
                columns: table => new
                {
                    WorkspaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapacityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkspaceCapacity", x => new { x.WorkspaceId, x.CapacityId });
                    table.ForeignKey(
                        name: "FK_WorkspaceCapacity_Capacity_CapacityId",
                        column: x => x.CapacityId,
                        principalTable: "Capacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkspaceCapacity_Workspace_WorkspaceId",
                        column: x => x.WorkspaceId,
                        principalTable: "Workspace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookingType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Room" });

            migrationBuilder.InsertData(
                table: "BookingType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Desk" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_WorkspaceId",
                table: "Booking",
                column: "WorkspaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_WorkspaceId",
                table: "Picture",
                column: "WorkspaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workspace_BookingTypeId",
                table: "Workspace",
                column: "BookingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkspaceCapacity_CapacityId",
                table: "WorkspaceCapacity",
                column: "CapacityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "WorkspaceCapacity");

            migrationBuilder.DropTable(
                name: "Capacity");

            migrationBuilder.DropTable(
                name: "Workspace");

            migrationBuilder.DropTable(
                name: "BookingType");
        }
    }
}
