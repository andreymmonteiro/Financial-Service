﻿// <auto-generated />
using System;
using Financial.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Financial.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220323004929_finance")]
    partial class finance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FinanceAccountType")
                        .HasColumnType("int");

                    b.Property<Guid>("PaymentTermsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("FinanceAccounts");
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsItemsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Addition")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("FinanceAccountId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("GrossTotal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.HasIndex("FinanceAccountId");

                    b.ToTable("FinanceAccountsItems");
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsPaymentItemsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("FinanceAccountsItemsId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Payday")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("FinanceAccountsItemsId");

                    b.ToTable("FinanceAccountsPaymentItems");
                });

            modelBuilder.Entity("Financial.Domain.Entities.PaymentTerms.PaymentTermsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ForceExpiration")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTerms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b57b2ff9-b04f-4aa2-aa52-d0d57d9cd4bc"),
                            CompanyId = new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"),
                            CreateAt = new DateTime(2022, 3, 22, 21, 49, 29, 265, DateTimeKind.Local).AddTicks(7275),
                            Description = "Á vista",
                            ForceExpiration = 0,
                            UpdateAt = new DateTime(2022, 3, 22, 21, 49, 29, 266, DateTimeKind.Local).AddTicks(5008)
                        },
                        new
                        {
                            Id = new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"),
                            CompanyId = new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"),
                            CreateAt = new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4866),
                            Description = "30 dias",
                            ForceExpiration = 0,
                            UpdateAt = new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4874)
                        });
                });

            modelBuilder.Entity("Financial.Domain.Entities.PaymentTerms.PaymentTermsItemsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Addition")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Days")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("PaymentTermsId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentTermsId");

                    b.ToTable("PaymentTermsItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eda34963-7132-4819-a900-552e202a8e03"),
                            Addition = 0m,
                            CompanyId = new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"),
                            CreateAt = new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5289),
                            Days = 30,
                            Discount = 0m,
                            PaymentTermsId = new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"),
                            UpdateAt = new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5294)
                        });
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsItemsEntity", b =>
                {
                    b.HasOne("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsEntity", "FinanceAccount")
                        .WithMany("FinanceAccountsItems")
                        .HasForeignKey("FinanceAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinanceAccount");
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsPaymentItemsEntity", b =>
                {
                    b.HasOne("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsItemsEntity", "FinanceAccountsItems")
                        .WithMany("PaymentItems")
                        .HasForeignKey("FinanceAccountsItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinanceAccountsItems");
                });

            modelBuilder.Entity("Financial.Domain.Entities.PaymentTerms.PaymentTermsItemsEntity", b =>
                {
                    b.HasOne("Financial.Domain.Entities.PaymentTerms.PaymentTermsEntity", "PaymentTerms")
                        .WithMany("PaymentTermsItems")
                        .HasForeignKey("PaymentTermsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentTerms");
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsEntity", b =>
                {
                    b.Navigation("FinanceAccountsItems");
                });

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccountsItemsEntity", b =>
                {
                    b.Navigation("PaymentItems");
                });

            modelBuilder.Entity("Financial.Domain.Entities.PaymentTerms.PaymentTermsEntity", b =>
                {
                    b.Navigation("PaymentTermsItems");
                });
#pragma warning restore 612, 618
        }
    }
}
