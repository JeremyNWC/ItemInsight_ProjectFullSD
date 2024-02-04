using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fcb156-5bbc-4cf8-b475-e2ad5cc71320", "AQAAAAIAAYagAAAAEHuCcADXpi+7FNi8nMDFK0Psm7mbGuLJ9T5Tomg/Na3Pq8EZaOzXiJfuVRh/hAOVLQ==", "11fe97c1-244e-45b5-95f4-9af3ef27c59e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cd7a888-d2d2-47d8-aa44-8d052379d80e", "AQAAAAIAAYagAAAAEP11xB8nYrOXzOBxQuP3G04+Xw3WsLW5aHGnClTD8vcqzJfAU5X2JZKZ6cnT77uUaA==", "b77824a3-eb5b-422d-bc40-d43e7e9fbe0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97aab7be-cb02-40d9-ab94-4a72637517fd", "AQAAAAIAAYagAAAAEEEq3wQRn3t6cItKDRLK8VqOjpw7bQI0wrtbW0HHB2zhz8yOi6ZMfbb2J0apL/eBvQ==", "550b2862-ffee-44ea-b575-e8793abbe6f4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 2, 4, 16, 7, 51, 414, DateTimeKind.Local).AddTicks(127) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49236a65-6bb5-4bf8-be8f-ab87dd6efa45", "AQAAAAIAAYagAAAAEIVUbt1gkbYZzJMGBAdW/38SDQj7yL+QiUqzJATBwA/BMQucFU01Ue0+Km2ssYtyoA==", "296304c8-4575-4bd0-9e50-0865bda34ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede0910f-dd62-452c-8eb8-d187d13a1b78", "AQAAAAIAAYagAAAAELU7FTmc3Flq226PxJvVChX7qA4HQGEFCHB1KwPLUeCL3z1vGGA2dYtS+z+JPn1mFA==", "36e87f42-0c84-4589-8d81-dcbc940de913" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08b9096-8022-45d4-8032-8859ac6cd7de", "AQAAAAIAAYagAAAAEGbUa0gIDXzqNtkNNt5IhM1/QtQj1W0rp9nHOEaLj+5Z8FqFEpP+6lr4DAgKIGuR7Q==", "65f25fe5-fe63-4784-9967-f0fbb20765c0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4226), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 2, 4, 13, 17, 5, 290, DateTimeKind.Local).AddTicks(4254) });
        }
    }
}
