using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class finance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("659fea76-dc49-44eb-a907-cb5820f78762"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("b836bec6-79fc-4926-bd76-889b7c090977"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("f3536b08-682b-4063-831f-68d9486517c1"));

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("b57b2ff9-b04f-4aa2-aa52-d0d57d9cd4bc"), new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 265, DateTimeKind.Local).AddTicks(7275), "Á vista", 0, new DateTime(2022, 3, 22, 21, 49, 29, 266, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"), new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4866), "30 dias", 0, new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("eda34963-7132-4819-a900-552e202a8e03"), 0m, new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5289), 30, 0m, new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5294) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("b57b2ff9-b04f-4aa2-aa52-d0d57d9cd4bc"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("eda34963-7132-4819-a900-552e202a8e03"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"));

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("659fea76-dc49-44eb-a907-cb5820f78762"), new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 64, DateTimeKind.Local).AddTicks(6041), "Á vista", 0, new DateTime(2022, 3, 21, 21, 3, 42, 65, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("f3536b08-682b-4063-831f-68d9486517c1"), new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4171), "30 dias", 0, new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("b836bec6-79fc-4926-bd76-889b7c090977"), 0m, new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4608), 30, 0m, new Guid("f3536b08-682b-4063-831f-68d9486517c1"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4613) });
        }
    }
}
