using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedCustom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee5887f-8fbd-45e9-9f7e-80abfb43142e", "AQAAAAIAAYagAAAAEDXsfRTxArZLNGRWOQmuyBoKTu+zd7BZJ5XZUVDdcF0RmLEb42Y68uZAU5YaWl/0Qw==", "da6f82d6-cdcc-4d24-8663-6924942ce620" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4dfd43-23fc-4f10-946d-9d436c5a377d", "AQAAAAIAAYagAAAAEHf6RfLGPt2s3XR9SuvR4We/b0gpSoCrBY6hPm00dNSZWFTflwztWgkzHVhcLuG5wA==", "70eb9501-86c9-4151-8151-c3eb3626aa96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf28875d-9d24-4c78-862e-5b2d2aa3c344", "AQAAAAIAAYagAAAAED1MRYaFGudQ1qwWNelAVExYeU1q0ICPqYGczKZTmryifLotPkutNDeWGkDoEF7ILg==", "06122416-acb6-437e-a1f6-70f8cd68c159" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5383), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5388), new DateTime(2024, 2, 3, 6, 57, 53, 639, DateTimeKind.Local).AddTicks(5389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
