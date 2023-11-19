﻿// <auto-generated />
using C__VSCode.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CVSCode.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20231118201836_AddSalary")]
    partial class AddSalary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("C__VSCode.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Bradesco")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Neon")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Nubank")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("C__VSCode.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Health")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Housing")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Leisure")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Studies")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
