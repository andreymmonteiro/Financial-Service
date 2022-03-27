using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class sql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("25546f86-48e6-403e-8a2b-95964ebfee96"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("7ce20fd9-11e3-4092-98fe-4b58d1acaaff"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("787f7283-3173-405b-abb6-b100347dec69"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("25546f86-48e6-403e-8a2b-95964ebfee96"), new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 742, DateTimeKind.Local).AddTicks(7745), "Á vista", 0, new DateTime(2022, 3, 23, 11, 3, 12, 744, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("787f7283-3173-405b-abb6-b100347dec69"), new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2168), "30 dias", 0, new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("7ce20fd9-11e3-4092-98fe-4b58d1acaaff"), 0m, new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2757), 30, 0m, new Guid("787f7283-3173-405b-abb6-b100347dec69"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2761) });
        }
    }
}
