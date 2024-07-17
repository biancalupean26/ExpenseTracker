﻿// <auto-generated />
using System;
using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ExpenseTrackerContext))]
    [Migration("20240717065717_AddIncomesTable")]
    partial class AddIncomesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpenseTracker.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Travel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Education"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 6,
                            Name = "House"
                        });
                });

            modelBuilder.Entity("ExpenseTracker.Data.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Planned")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100.0m,
                            CategoryId = 1,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2293),
                            Planned = true,
                            Title = "Grocery Shopping"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 50.0m,
                            CategoryId = 2,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2347),
                            Planned = false,
                            Title = "Train Ticket"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 30.0m,
                            CategoryId = 3,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2349),
                            Planned = true,
                            Title = "Movie Night"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 200.0m,
                            CategoryId = 4,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2351),
                            Planned = true,
                            Title = "Online Course"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 150.0m,
                            CategoryId = 5,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2352),
                            Planned = false,
                            Title = "New Jacket"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 800.0m,
                            CategoryId = 6,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2353),
                            Planned = true,
                            Title = "Rent"
                        });
                });

            modelBuilder.Entity("ExpenseTracker.Models.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Incomes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 500.0m,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2384),
                            Title = "Freelance Gig",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 1000.0m,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2388),
                            Title = "Scholarship Grant",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 200.0m,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2390),
                            Title = "Birthday Gift",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Amount = 10000.0m,
                            Date = new DateTime(2024, 7, 17, 6, 57, 16, 710, DateTimeKind.Utc).AddTicks(2392),
                            Title = "Lottery Prize",
                            Type = 3
                        });
                });

            modelBuilder.Entity("ExpenseTracker.Data.Models.Expense", b =>
                {
                    b.HasOne("ExpenseTracker.Data.Models.Category", "Category")
                        .WithMany("Expenses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Income", b =>
                {
                    b.HasOne("ExpenseTracker.Data.Models.Category", null)
                        .WithMany("Icomes")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ExpenseTracker.Data.Models.Category", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Icomes");
                });
#pragma warning restore 612, 618
        }
    }
}
