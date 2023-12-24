﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts;

#nullable disable

namespace TrendMusic.ECommerce.DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Blues",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(900),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(901)
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Klasik Müzik",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(903),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(903)
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Halk Müzikleri",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(905),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(905)
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Elektronik Müzik",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(906),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(907)
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Hip - Hop",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(908),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(908)
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Cazz ",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(909),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(910)
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Pop ",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(910),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(911)
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Rock",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(912),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(912)
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Çocuk Müzikleri ",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(913),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(914)
                        },
                        new
                        {
                            Id = 10,
                            CategoryName = "Dini Müzik Türleri",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(915),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(915)
                        },
                        new
                        {
                            Id = 11,
                            CategoryName = "Enstrümantal",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(916),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(917)
                        },
                        new
                        {
                            Id = 12,
                            CategoryName = "Tüm Kategoriler",
                            CreatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(918),
                            IsActive = true,
                            UpdatedDate = new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(918)
                        });
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Identity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.MusicEntities.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProductDemoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductFullPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.MusicEntities.ProductCategories", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Product", "product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("product");
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Product", b =>
                {
                    b.HasOne("TrendMusic.ECommerce.Entities.Concrete.Identity.AppUser", "ProductOwner")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductOwner");
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("TrendMusic.ECommerce.Entities.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
