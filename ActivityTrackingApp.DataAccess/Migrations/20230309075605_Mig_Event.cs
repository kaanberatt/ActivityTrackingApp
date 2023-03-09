using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityTrackingApp.DataAccess.Migrations
{
    public partial class Mig_Event : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTopics_EventTopicId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeId1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTopicId1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTypeId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventTopicId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventTypeId1",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "EventTypeId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EventTopicId",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                column: "EventTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTopics_EventTopicId",
                table: "Events",
                column: "EventTopicId",
                principalTable: "EventTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events",
                column: "EventTypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTopics_EventTopicId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTopicId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventTypeId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "EventTypeId",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EventTopicId",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EventTopicId1",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeId1",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "createdDate" },
                values: new object[] { new byte[] { 188, 242, 159, 196, 239, 52, 99, 42, 183, 56, 240, 173, 128, 21, 0, 129, 243, 147, 50, 194, 142, 19, 228, 232, 250, 226, 184, 51, 75, 56, 147, 90, 42, 6, 115, 231, 69, 4, 132, 157, 226, 55, 169, 162, 217, 156, 198, 85, 234, 100, 137, 35, 171, 175, 45, 181, 179, 112, 173, 161, 215, 30, 16, 54 }, new byte[] { 74, 116, 189, 183, 197, 255, 97, 247, 78, 38, 23, 98, 157, 239, 219, 226, 72, 185, 49, 89, 12, 76, 126, 255, 222, 218, 131, 12, 104, 118, 229, 10, 180, 135, 112, 196, 24, 180, 203, 80, 11, 193, 162, 171, 165, 65, 128, 236, 186, 70, 20, 223, 233, 124, 154, 4, 198, 94, 237, 56, 191, 152, 146, 72, 130, 229, 101, 93, 208, 234, 212, 223, 228, 20, 88, 96, 221, 114, 172, 25, 98, 82, 202, 125, 224, 239, 127, 129, 151, 17, 42, 122, 63, 167, 172, 239, 247, 130, 130, 24, 235, 196, 201, 31, 133, 242, 85, 236, 47, 39, 38, 163, 175, 222, 9, 25, 49, 166, 187, 182, 88, 121, 8, 51, 77, 253, 73, 95 }, new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 8, 0, 55, 57, 756, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTopicId1",
                table: "Events",
                column: "EventTopicId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId1",
                table: "Events",
                column: "EventTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTopics_EventTopicId1",
                table: "Events",
                column: "EventTopicId1",
                principalTable: "EventTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeId1",
                table: "Events",
                column: "EventTypeId1",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
