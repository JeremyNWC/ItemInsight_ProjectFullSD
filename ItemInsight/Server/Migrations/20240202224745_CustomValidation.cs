using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class CustomValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staffs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Producers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Consumers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Consumers",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eebda65-eefb-46b7-aae8-b8689cec775d", "AQAAAAIAAYagAAAAEC4IK9Rg1gfMzI4EkOHZUGYenqprEBlzc7yjPkTdkWLGzKVoGvGE1uojHO/JmkcWWw==", "fde19a4f-d815-4639-b0c9-4df698a11709" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422cf68f-d782-4688-bfbe-1e60bd724b1e", "AQAAAAIAAYagAAAAEPDGw/RqSlDil0wbYo3Cno80crelU4auzr96k4cIbJfUCg8BYWqgCzWMO1sgify3zg==", "2d5495e8-7f36-4c96-8f24-c50ed28867d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23c811a8-7c0a-4b63-9053-fce15778dbb1", "AQAAAAIAAYagAAAAEAQjkmHIpvs1LJr9U0lSdKlLutqLPG4N5w+twlZxH7xrm/L8GWi1vhsrjjholHRl9Q==", "8ef3a303-d991-4276-a845-bd98c33b81cc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8327), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 2, 3, 3, 16, 42, 949, DateTimeKind.Local).AddTicks(6358) });
        }
    }
}
