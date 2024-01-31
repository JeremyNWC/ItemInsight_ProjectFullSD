using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class ControllerTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da48e36a-c743-46b6-bf99-3e670f6e4c9b", "AQAAAAIAAYagAAAAEOBZetmgBHpyp86NxiVHRLXVhKXZMwS6hpfRAUQO1qPYxn92HttC6yZJlvH2pXYLPQ==", "274cb905-2867-4db9-b589-794af5491924" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a018cfb1-5cb3-4c25-ad47-172aea7aa78f", "AQAAAAIAAYagAAAAEIQhmcXeBTpadtGjVmbC+dj1RO4f+p5Eb/LbZWYRqZgdN324AjUvLzgYGf7iyMBr4g==", "126fa598-dbd5-4092-8d00-43d8c5ec5ef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "934731d1-e6f4-4bee-82b5-cea482153a8b", "AQAAAAIAAYagAAAAELed9tYtRChYnEEuP6TMLEAVDjnq6RnTO7HJyr9fonqvCnvvT+LzJuzQNgG0MqU7bA==", "84cb53f6-67fc-4063-90cf-c979ef7238da" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(1957), new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 1, 31, 23, 11, 36, 608, DateTimeKind.Local).AddTicks(773) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f0d1fb-0013-4635-ae9d-ed40348aa386", "AQAAAAIAAYagAAAAEEttCmTKn2gZotSVCf1+5LmL2gsHnmRTLladWoDeCweytLfTPL+fjREn1WX0fJx2XA==", "30ef8e88-79f1-441d-8654-cdb988638403" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f26181c6-e570-479b-95ad-f3a41a44d7da", "AQAAAAIAAYagAAAAEJ5MN/W85K3xdIjtDv3E6yxL79XeVtaJpAYX5MzjsO4bHtAWc9v+gx11L6/ihMC91A==", "e43800dc-ed5c-44bc-be28-e0380684303e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e4f1dd-b27a-406f-a004-5a7c2064be01", "AQAAAAIAAYagAAAAEJ/QcmieTVoKdrkzJCmS2paxqxlqNNfUsKxzgqNA0zcSfFoDZhQWsILtSgQTzPUPlQ==", "2ab595db-e757-42e1-8598-98b0f80ed4bf" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(67) });
        }
    }
}
