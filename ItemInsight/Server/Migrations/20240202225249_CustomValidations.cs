using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class CustomValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a380241a-5cf9-471c-b5bf-01535c686c0c", "AQAAAAIAAYagAAAAEG+t2jjXvj5NIRngA+HCmSngDK1LcYVKHkEsmEcq2hb+blZJShK+lAgrXaNI9SWQBg==", "ec2027cb-d3aa-49d8-8b76-fa84542d9d6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92188344-f9d3-4532-859c-2dc98515d69c", "AQAAAAIAAYagAAAAEMcw46ShjJ7lFKAH6WH23m0qDSEVn0HlWbPrYV1Oxd9wRib1+pOSDrUFuPRSBwyIkA==", "8399bea9-98a8-4900-bd89-4e4e33024258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df09547-0114-4d15-aa10-68c023988485", "AQAAAAIAAYagAAAAEDGxwF9OGmSgJFb7UwIxyPP1hiIjWgRjFyQ/1T4uLuI+DrpCs6lG2b0TKht58U9Idg==", "29c5c3ee-4602-4fbb-94ba-5684903ac7bd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9874), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7808), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7814), new DateTime(2024, 2, 3, 6, 52, 49, 512, DateTimeKind.Local).AddTicks(7815) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a034b21-f856-4025-ba14-74e39a985948", "AQAAAAIAAYagAAAAECH4LbjE2XYujrwfo/YPLG3xBgS36ZSVZq5PmqdPxrQvC9vIS998SFXZgAR6BQIHDQ==", "a1454ae9-80f4-4070-897b-3d4385f0156e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa21775e-099f-4e5f-91c4-6dac3d834b1a", "AQAAAAIAAYagAAAAEIHSpYvfuBY184/BCl0e609BoZh2DqRo5qhcnsSiYh1hpJCIqE3RNrlyJUTqnWBElA==", "3b094db0-a5ad-4b13-8314-f41e99881b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb405008-615b-410a-86d7-99cb505857d3", "AQAAAAIAAYagAAAAEMNELtNhNNrL8t59E/xYSv2AkWkqEMlIq99WMdVC5SAXRyoh5MY/eVSYN/ZJ1Tb5WQ==", "4b2e81ed-c90a-4126-9d36-2c2783e7f330" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 2, 3, 6, 47, 45, 386, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9626), new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9629), new DateTime(2024, 2, 3, 6, 47, 45, 385, DateTimeKind.Local).AddTicks(9630) });
        }
    }
}
