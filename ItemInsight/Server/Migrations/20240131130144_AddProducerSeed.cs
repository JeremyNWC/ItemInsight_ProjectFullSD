using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemInsight.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddProducerSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8390bd1c-4d91-452e-9a15-1a2c75c03553", "AQAAAAIAAYagAAAAEB2P0cLGwmgTBa8e8qMUqxlA4wsfVieDqUHMC9cw4U9ZPHHKHKx+lO6KyUhsw2ex9w==", "04d4050c-225b-4383-9ff5-cec368f41f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba231b1f-163f-4737-b72f-8da1f8a54e3d", "AQAAAAIAAYagAAAAEBmM+EvN7Jgp5cX1VTqtQzU9fyAglUvWxZZiaNRSdJMAvqW8UDU9CWy6OY0ksJRzQQ==", "1cfc3965-2254-4d3d-a43d-b49fc6204f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033b6085-dda2-4da4-a3bf-05345d965dc8", "AQAAAAIAAYagAAAAEBFD3pN61no5F/KlyIlf9PNXO+G/qlrJ1oHTu9PgdX8I2BIssbwT7zb//RIT49/lmg==", "3b50dbf9-bd30-48c0-9cf8-e44273911eac" });
        }
    }
}
