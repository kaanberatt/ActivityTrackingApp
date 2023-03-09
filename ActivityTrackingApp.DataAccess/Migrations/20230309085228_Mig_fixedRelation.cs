using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityTrackingApp.DataAccess.Migrations
{
    public partial class Mig_fixedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTopics_EventTopicId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTopicId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventTopicId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventTopicId",
                table: "UserActivities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "createdDate" },
                values: new object[] { new byte[] { 109, 235, 250, 117, 193, 70, 14, 57, 160, 48, 20, 246, 95, 101, 87, 199, 221, 252, 218, 128, 130, 140, 4, 233, 195, 245, 58, 201, 112, 53, 200, 80, 28, 84, 231, 149, 143, 82, 205, 113, 151, 238, 92, 25, 184, 21, 227, 14, 126, 6, 62, 112, 224, 242, 63, 251, 223, 39, 178, 136, 196, 36, 130, 206 }, new byte[] { 111, 122, 192, 191, 229, 142, 113, 133, 68, 203, 145, 132, 158, 35, 100, 53, 106, 180, 129, 53, 209, 183, 130, 23, 9, 14, 173, 250, 43, 80, 140, 19, 14, 16, 170, 167, 173, 157, 154, 94, 254, 203, 211, 213, 46, 143, 56, 233, 45, 37, 107, 25, 118, 166, 205, 93, 228, 199, 42, 207, 75, 85, 57, 247, 244, 28, 201, 251, 106, 2, 108, 172, 9, 131, 26, 113, 167, 81, 101, 128, 165, 1, 38, 134, 72, 241, 86, 229, 70, 166, 131, 45, 1, 21, 192, 128, 148, 215, 76, 30, 74, 157, 78, 145, 123, 46, 109, 119, 59, 79, 221, 146, 33, 31, 66, 155, 250, 6, 74, 103, 184, 155, 237, 69, 53, 92, 144, 168 }, new DateTime(2023, 3, 9, 11, 52, 28, 304, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 11, 52, 28, 304, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 11, 52, 28, 304, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 11, 52, 28, 304, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 11, 52, 28, 304, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_EventTopicId",
                table: "UserActivities",
                column: "EventTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_EventTopics_EventTopicId",
                table: "UserActivities",
                column: "EventTopicId",
                principalTable: "EventTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_EventTopics_EventTopicId",
                table: "UserActivities");

            migrationBuilder.DropIndex(
                name: "IX_UserActivities_EventTopicId",
                table: "UserActivities");

            migrationBuilder.DropColumn(
                name: "EventTopicId",
                table: "UserActivities");

            migrationBuilder.AddColumn<int>(
                name: "EventTopicId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "createdDate" },
                values: new object[] { new byte[] { 13, 140, 78, 16, 142, 24, 254, 155, 205, 50, 132, 128, 143, 214, 238, 57, 238, 87, 80, 154, 42, 135, 240, 189, 67, 119, 41, 3, 119, 0, 136, 30, 207, 146, 228, 107, 127, 45, 129, 197, 202, 217, 211, 175, 102, 229, 16, 44, 250, 57, 183, 25, 190, 83, 5, 127, 215, 67, 123, 188, 113, 137, 152, 216 }, new byte[] { 87, 240, 50, 174, 98, 137, 18, 75, 48, 34, 129, 100, 198, 42, 165, 187, 9, 144, 123, 67, 219, 16, 84, 186, 65, 161, 38, 116, 125, 134, 91, 154, 188, 89, 58, 1, 52, 48, 214, 35, 116, 124, 135, 198, 252, 32, 79, 114, 251, 10, 5, 94, 187, 215, 241, 52, 239, 114, 183, 196, 137, 250, 170, 113, 97, 160, 246, 187, 125, 93, 135, 74, 94, 42, 185, 99, 210, 80, 241, 230, 84, 250, 122, 218, 21, 198, 221, 242, 224, 93, 100, 157, 131, 111, 63, 134, 154, 92, 246, 123, 216, 255, 230, 244, 85, 224, 197, 100, 7, 197, 0, 29, 174, 157, 21, 162, 84, 109, 17, 8, 46, 252, 203, 255, 247, 165, 77, 131 }, new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTopicId",
                table: "Events",
                column: "EventTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTopics_EventTopicId",
                table: "Events",
                column: "EventTopicId",
                principalTable: "EventTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
