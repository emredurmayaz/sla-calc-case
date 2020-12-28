using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SLACalculation.Migrations
{
    public partial class SeedComplaintType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComplaintType",
                columns: new[] { "Id", "IsDeleted", "Name", "Priorty" },
                values: new object[,]
                {
                    { new Guid("9523dcfc-c58e-485d-ba2d-1d0af08830a5"), false, "ATM Card captured", 1 },
                    { new Guid("44247379-ff3d-403e-b9ab-a79b676be656"), false, "Rude attitude of staff", 3 },
                    { new Guid("0bfa4005-0b48-4dc0-b073-9457ba8e8f67"), false, "Long waiting time in branches", 2 },
                    { new Guid("1029b9fe-707d-45a7-be6d-e181a98245bd"), false, "Disputed transaction in credit card", 2 },
                    { new Guid("f988ebef-0ba5-4ccd-80e7-f0e515116448"), false, "Cash deposited but not reflected in the account", 4 },
                    { new Guid("8f4e0a5e-eb39-4354-9c37-00bf31185e9b"), false, "Credit card application takes too long", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("0bfa4005-0b48-4dc0-b073-9457ba8e8f67"));

            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("1029b9fe-707d-45a7-be6d-e181a98245bd"));

            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("44247379-ff3d-403e-b9ab-a79b676be656"));

            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("8f4e0a5e-eb39-4354-9c37-00bf31185e9b"));

            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("9523dcfc-c58e-485d-ba2d-1d0af08830a5"));

            migrationBuilder.DeleteData(
                table: "ComplaintType",
                keyColumn: "Id",
                keyValue: new Guid("f988ebef-0ba5-4ccd-80e7-f0e515116448"));
        }
    }
}
