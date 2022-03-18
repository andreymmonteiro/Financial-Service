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
    [Migration("20220316001917_mySql")]
    partial class mySql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("Financial.Domain.Entities.FinanceAccounts.FinanceAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FinanceAccountItemId")
                        .HasColumnType("int");

                    b.Property<int>("FinanceAccountType")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTermsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("FinanceAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
