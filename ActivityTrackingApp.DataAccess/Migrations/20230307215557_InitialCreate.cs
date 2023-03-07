using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityTrackingApp.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTopicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTopicId1 = table.Column<int>(type: "int", nullable: false),
                    EventTypeId1 = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventTopics_EventTopicId1",
                        column: x => x.EventTopicId1,
                        principalTable: "EventTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeId1",
                        column: x => x.EventTypeId1,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivities_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActivities_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "BirthDate", "City", "Education", "Email", "EmailConfirmed", "FirstName", "IsActived", "LastName", "PasswordHash", "PasswordSalt", "Phone", "PhoneNumberConfirmed", "Role", "Tc", "Token", "TokenExpiryDate", "TwoFactorEnabled", "createdDate", "updatedDate" },
                values: new object[] { 1, 0, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sakarya", "Üniversite", "kaan@gmail.com", true, "Kaan Berat", true, "Tokat", new byte[] { 188, 242, 159, 196, 239, 52, 99, 42, 183, 56, 240, 173, 128, 21, 0, 129, 243, 147, 50, 194, 142, 19, 228, 232, 250, 226, 184, 51, 75, 56, 147, 90, 42, 6, 115, 231, 69, 4, 132, 157, 226, 55, 169, 162, 217, 156, 198, 85, 234, 100, 137, 35, 171, 175, 45, 181, 179, 112, 173, 161, 215, 30, 16, 54 }, new byte[] { 74, 116, 189, 183, 197, 255, 97, 247, 78, 38, 23, 98, 157, 239, 219, 226, 72, 185, 49, 89, 12, 76, 126, 255, 222, 218, 131, 12, 104, 118, 229, 10, 180, 135, 112, 196, 24, 180, 203, 80, 11, 193, 162, 171, 165, 65, 128, 236, 186, 70, 20, 223, 233, 124, 154, 4, 198, 94, 237, 56, 191, 152, 146, 72, 130, 229, 101, 93, 208, 234, 212, 223, 228, 20, 88, 96, 221, 114, 172, 25, 98, 82, 202, 125, 224, 239, 127, 129, 151, 17, 42, 122, 63, 167, 172, 239, 247, 130, 130, 24, 235, 196, 201, 31, 133, 242, 85, 236, 47, 39, 38, 163, 175, 222, 9, 25, 49, 166, 187, 182, 88, 121, 8, 51, 77, 253, 73, 95 }, "05348952284", true, "User", "31112554896", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(1032), null });

            migrationBuilder.InsertData(
                table: "EventTopics",
                columns: new[] { "Id", "Name", "createdDate", "updatedDate" },
                values: new object[,]
                {
                    { 1, "Aksiyon", new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(843), null },
                    { 2, "Bilim-Kurgu", new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(856), null }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name", "createdDate", "updatedDate" },
                values: new object[,]
                {
                    { 1, "Okuma", new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(989), null },
                    { 2, "Dinleme", new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(990), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTopicId1",
                table: "Events",
                column: "EventTopicId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId1",
                table: "Events",
                column: "EventTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_AppUserId",
                table: "UserActivities",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_EventId",
                table: "UserActivities",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTopics");

            migrationBuilder.DropTable(
                name: "EventTypes");
        }
    }
}
