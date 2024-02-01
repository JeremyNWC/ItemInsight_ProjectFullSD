using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class FullSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "431ef00b-c8d6-436d-a477-015439b20109", "AQAAAAIAAYagAAAAEMrUtJcjTzWsdEEVN4i3imZ5UBCovQ+fLCahwD4F0yhEl21NJwKHEeV4YVZ04aHHEg==", "6972c00b-9a75-4bd8-a09f-5d658da078eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed56c5a-2938-4865-91b4-89a5c2736619", "AQAAAAIAAYagAAAAEM6xJ6tM10is8Xge1F6jFOWxRcGfVkJFag1fYXdFlaUYbnmi3yEysfZcFIQ5QOlORA==", "da8e1153-d99a-400b-b78f-5dc5fef2947d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2e7bb4-b473-4bef-b2b2-b4790d6bf5cd", "AQAAAAIAAYagAAAAEP+F6Nm92B+MkWpu0E/CbWl84VtY9Of73jVxM1hcV0MeL0AQkXcYNbDo80DtnnM5RQ==", "dde7dcdd-9805-4fb3-84ce-9826075669e0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(1113), new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(1153), new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 2, 1, 10, 0, 42, 676, DateTimeKind.Local).AddTicks(598) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
