using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityTrackingApp.DataAccess.Migrations
{
    public partial class Mig_AddedGenderinAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gender", "PasswordHash", "PasswordSalt", "createdDate" },
                values: new object[] { "Erkek", new byte[] { 23, 45, 32, 249, 66, 94, 129, 239, 227, 70, 70, 183, 173, 19, 155, 226, 66, 185, 69, 121, 6, 8, 22, 168, 48, 73, 239, 57, 18, 209, 95, 142, 245, 47, 239, 168, 222, 7, 226, 157, 130, 131, 37, 250, 66, 57, 3, 181, 11, 210, 1, 34, 143, 96, 25, 2, 105, 149, 191, 130, 128, 157, 105, 121 }, new byte[] { 174, 62, 107, 170, 59, 27, 43, 233, 173, 44, 59, 30, 89, 55, 46, 199, 232, 136, 50, 112, 29, 119, 218, 48, 227, 125, 146, 220, 11, 223, 199, 107, 54, 247, 153, 100, 242, 226, 165, 95, 109, 87, 152, 61, 5, 126, 138, 110, 39, 197, 187, 90, 184, 218, 92, 29, 107, 0, 198, 45, 250, 157, 94, 141, 65, 103, 40, 234, 0, 182, 244, 151, 196, 189, 180, 167, 249, 36, 47, 122, 17, 0, 183, 199, 22, 182, 168, 36, 155, 112, 78, 16, 78, 63, 223, 177, 118, 146, 96, 157, 202, 197, 82, 51, 125, 45, 240, 234, 206, 105, 180, 149, 127, 49, 182, 108, 91, 169, 19, 44, 84, 165, 145, 8, 247, 213, 223, 207 }, new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "EventTopics",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdDate",
                value: new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4875));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AppUsers");

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
        }
    }
}
