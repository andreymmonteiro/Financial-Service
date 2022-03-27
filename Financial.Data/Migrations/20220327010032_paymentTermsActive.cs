using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class paymentTermsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("ff14ec43-a5c0-490d-ae85-0657302d0740"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("3ba4ab5c-491f-4351-a40b-44b500f84f58"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("fbb6cfde-770e-4013-80ef-a6eea5b0bbe7"));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "PaymentTerms",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "Active", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("5edc90a6-35d2-4ddb-885c-aa4f4f831461"), false, new Guid("3221e506-cc9b-4d50-850f-66c4199fc860"), new DateTime(2022, 3, 26, 22, 0, 32, 539, DateTimeKind.Local).AddTicks(3114), "Á vista", 0, new DateTime(2022, 3, 26, 22, 0, 32, 540, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "Active", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("d0671a2b-f1b5-4f7a-ae3b-ec4ddc7efba9"), false, new Guid("3221e506-cc9b-4d50-850f-66c4199fc860"), new DateTime(2022, 3, 26, 22, 0, 32, 541, DateTimeKind.Local).AddTicks(7104), "30 dias", 0, new DateTime(2022, 3, 26, 22, 0, 32, 541, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("29db9e49-e95c-4560-9c5d-14fb0ecdbf4c"), 0m, new Guid("3221e506-cc9b-4d50-850f-66c4199fc860"), new DateTime(2022, 3, 26, 22, 0, 32, 541, DateTimeKind.Local).AddTicks(7680), 30, 0m, new Guid("d0671a2b-f1b5-4f7a-ae3b-ec4ddc7efba9"), new DateTime(2022, 3, 26, 22, 0, 32, 541, DateTimeKind.Local).AddTicks(7684) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("5edc90a6-35d2-4ddb-885c-aa4f4f831461"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("29db9e49-e95c-4560-9c5d-14fb0ecdbf4c"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("d0671a2b-f1b5-4f7a-ae3b-ec4ddc7efba9"));

            migrationBuilder.DropColumn(
                name: "Active",
                table: "PaymentTerms");

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("ff14ec43-a5c0-490d-ae85-0657302d0740"), new Guid("a9b1d8b5-59d5-40f2-bdd4-78aad9cae45c"), new DateTime(2022, 3, 26, 20, 54, 47, 97, DateTimeKind.Local).AddTicks(322), "Á vista", 0, new DateTime(2022, 3, 26, 20, 54, 47, 98, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("fbb6cfde-770e-4013-80ef-a6eea5b0bbe7"), new Guid("a9b1d8b5-59d5-40f2-bdd4-78aad9cae45c"), new DateTime(2022, 3, 26, 20, 54, 47, 99, DateTimeKind.Local).AddTicks(3830), "30 dias", 0, new DateTime(2022, 3, 26, 20, 54, 47, 99, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("3ba4ab5c-491f-4351-a40b-44b500f84f58"), 0m, new Guid("a9b1d8b5-59d5-40f2-bdd4-78aad9cae45c"), new DateTime(2022, 3, 26, 20, 54, 47, 99, DateTimeKind.Local).AddTicks(4464), 30, 0m, new Guid("fbb6cfde-770e-4013-80ef-a6eea5b0bbe7"), new DateTime(2022, 3, 26, 20, 54, 47, 99, DateTimeKind.Local).AddTicks(4469) });
        }
    }
}
