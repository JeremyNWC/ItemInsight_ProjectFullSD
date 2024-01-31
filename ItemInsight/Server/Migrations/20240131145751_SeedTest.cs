using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "CompanyName", "ContactNo", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "JaysFashion", "81079182", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jay@gmail.com", "Jay", null },
                    { 2, "NicFurn", "99283749", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nicole@gmail.com", "Nicole", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Cost", "CreatedBy", "DateCreated", "DateUpdated", "Name", "ProducerId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Fashion", 13.4, null, new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(917), "Dotted Dress", 1, null },
                    { 2, "Furniture", 99.900000000000006, null, new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(923), "Sofa", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Category", "ConsumerReview", "CreatedBy", "DateCreated", "DateUpdated", "ProductId", "Rating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Fashion", "Wonderful product", null, new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(62), 1, 5.0, null },
                    { 2, "Furniture", "Mediocre product", null, new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 1, 31, 22, 57, 50, 357, DateTimeKind.Local).AddTicks(67), 2, 3.5, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecde53eb-ddd0-41be-8783-4655c3b5952b", "AQAAAAIAAYagAAAAEI5wb8YJBwuJDvtioGhF7/E02n0Ri5JLGnCSBf+4t4vzq117kigeeNEFWQsu6IOPSw==", "7719c5d8-2b81-499d-9a43-1f9fbbdbbee0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa66296-1133-44d3-89f1-08e4c14a2733", "AQAAAAIAAYagAAAAECMqHthNvLaQ8KHMV2Vx+HRBl38u/GHo4D8dV1DdMlm9GycLdeuGberbgTs5tO6iDw==", "be345d7e-900c-4217-a851-30565110f1a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f364b097-55cf-4ae4-8099-583252a832e6", "AQAAAAIAAYagAAAAEC2dQ4PwTSgBaYCMycquvlUT63bQLQRGrV5oBoPGHmsuPLH4HvTqooO2OV4u77+W1Q==", "9163af9f-5643-483d-8e3a-661264afdcf9" });
        }
    }
}
