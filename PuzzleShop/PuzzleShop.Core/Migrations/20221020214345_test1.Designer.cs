﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PuzzleShop.Core;

#nullable disable

namespace PuzzleShop.Core.Migrations
{
    [DbContext(typeof(PuzzleShopContext))]
    [Migration("20221020214345_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6ed25511-7b94-4ba2-8b52-5463f67ea8e9",
                            ConcurrencyStamp = "11603511-406e-4c34-8d33-34246b10befc",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a730139b-0f1c-44b0-be07-6a8e169a6118",
                            ConcurrencyStamp = "52991ef8-0364-494c-88c2-6e77d5f8b919",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "886ad836-6686-4415-91eb-becdda0eb429",
                            ConcurrencyStamp = "f5c48721-c745-4eaa-9279-6d4447245d32",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a2b9b5c5-2232-454f-807b-25d18c28b604",
                            RoleId = "6ed25511-7b94-4ba2-8b52-5463f67ea8e9"
                        },
                        new
                        {
                            UserId = "a2b9b5c5-2232-454f-807b-25d18c28b604",
                            RoleId = "a730139b-0f1c-44b0-be07-6a8e169a6118"
                        },
                        new
                        {
                            UserId = "a2b9b5c5-2232-454f-807b-25d18c28b604",
                            RoleId = "886ad836-6686-4415-91eb-becdda0eb429"
                        },
                        new
                        {
                            UserId = "bf8e4923-67fe-4625-bc6a-06e8954a045f",
                            RoleId = "a730139b-0f1c-44b0-be07-6a8e169a6118"
                        },
                        new
                        {
                            UserId = "bf8e4923-67fe-4625-bc6a-06e8954a045f",
                            RoleId = "886ad836-6686-4415-91eb-becdda0eb429"
                        },
                        new
                        {
                            UserId = "b8bab7fd-5340-4712-9f93-32dfd6456bf8",
                            RoleId = "886ad836-6686-4415-91eb-becdda0eb429"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PuzzleShop.Core.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("PuzzleShop.Core.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("OrderListId")
                        .HasColumnType("int");

                    b.Property<int?>("PuzzleId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrderListId");

                    b.HasIndex("PuzzleId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OrderLists");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Articul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CountryId");

                    b.ToTable("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bf8e4923-67fe-4625-bc6a-06e8954a045f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bce94d17-86a5-4ff9-aa54-b372b822541d",
                            Email = "manager@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@PUZZLESHOP.COM",
                            NormalizedUserName = "MANAGER@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM8OxC+7ZLHVeiMzLFZMfX/QDPcxwNPL8KK4c1q1mmG7owapjKyji4jHzw8eRA3oCQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "895066f0-50d4-4729-83f6-28cdcaf56ecd",
                            TwoFactorEnabled = false,
                            UserName = "manager@puzzleshop.com"
                        },
                        new
                        {
                            Id = "b8bab7fd-5340-4712-9f93-32dfd6456bf8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cab3427e-45cb-4f46-8873-d1ea77457f4d",
                            Email = "customer@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@PUZZLESHOP.COM",
                            NormalizedUserName = "CUSTOMER@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJF2FebjHs+HHq4kmxNiZP/R3ks3dcljw4Buf3iRJTkIfozanrozdidFfQ0oiNslBA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5fad0ae4-844f-4b60-8460-f9107c4145d4",
                            TwoFactorEnabled = false,
                            UserName = "customer@puzzleshop.com"
                        },
                        new
                        {
                            Id = "a2b9b5c5-2232-454f-807b-25d18c28b604",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bd941e71-a08b-4fcb-b57d-ef3498217084",
                            Email = "admin@puzzleshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@PUZZLESHOP.COM",
                            NormalizedUserName = "ADMIN@PUZZLESHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGqcd989Af4dJJvs8yFfyrdqjieZzWrQfTZGSlCapIWPs7hBCNQbVrekp2919pqUHQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b8cc471-453d-45e6-a1ac-0d07ef9d223f",
                            TwoFactorEnabled = false,
                            UserName = "admin@puzzleshop.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PuzzleShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderItem", b =>
                {
                    b.HasOne("PuzzleShop.Core.OrderList", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderListId");

                    b.HasOne("PuzzleShop.Core.Puzzle", "Puzzle")
                        .WithMany("OrderItems")
                        .HasForeignKey("PuzzleId");

                    b.HasOne("PuzzleShop.Core.User", "User")
                        .WithMany("OrderItems")
                        .HasForeignKey("UserId");

                    b.Navigation("Puzzle");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.HasOne("PuzzleShop.Core.Brand", "Brand")
                        .WithMany("Puzzles")
                        .HasForeignKey("BrandId");

                    b.HasOne("PuzzleShop.Core.Country", "Country")
                        .WithMany("Puzzles")
                        .HasForeignKey("CountryId");

                    b.Navigation("Brand");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PuzzleShop.Core.Brand", b =>
                {
                    b.Navigation("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.Country", b =>
                {
                    b.Navigation("Puzzles");
                });

            modelBuilder.Entity("PuzzleShop.Core.OrderList", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PuzzleShop.Core.Puzzle", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("PuzzleShop.Core.User", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
