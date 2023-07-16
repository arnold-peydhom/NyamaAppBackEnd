﻿// <auto-generated />
using System;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(NyamaContext))]
    [Migration("20230701085410_updateTypeOfAttributesInAllTheClassAndModel")]
    partial class updateTypeOfAttributesInAllTheClassAndModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Achats"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Transport"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Deplacement"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Salaire"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Paris"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Marseille"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Lyon"
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Toulouse"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("District");

                    b.HasData(
                        new
                        {
                            DistrictId = 1,
                            CityId = 1,
                            Name = "Le Marais"
                        },
                        new
                        {
                            DistrictId = 2,
                            CityId = 1,
                            Name = "Montmartre"
                        },
                        new
                        {
                            DistrictId = 3,
                            CityId = 1,
                            Name = "Saint-Germain-des-Prés"
                        },
                        new
                        {
                            DistrictId = 4,
                            CityId = 1,
                            Name = "Le Quartier Latin"
                        },
                        new
                        {
                            DistrictId = 5,
                            CityId = 2,
                            Name = "Le Vieux-Port"
                        },
                        new
                        {
                            DistrictId = 6,
                            CityId = 2,
                            Name = "Le Panier"
                        },
                        new
                        {
                            DistrictId = 7,
                            CityId = 2,
                            Name = "Le Cours Julien"
                        },
                        new
                        {
                            DistrictId = 8,
                            CityId = 2,
                            Name = "La Corniche"
                        },
                        new
                        {
                            DistrictId = 9,
                            CityId = 3,
                            Name = "Vieux Lyon"
                        },
                        new
                        {
                            DistrictId = 10,
                            CityId = 3,
                            Name = "Presqu'île"
                        },
                        new
                        {
                            DistrictId = 11,
                            CityId = 3,
                            Name = "Croix-Rousse"
                        },
                        new
                        {
                            DistrictId = 12,
                            CityId = 3,
                            Name = "Confluence"
                        },
                        new
                        {
                            DistrictId = 13,
                            CityId = 4,
                            Name = "Capitole"
                        },
                        new
                        {
                            DistrictId = 14,
                            CityId = 4,
                            Name = "Saint-Cyprien"
                        },
                        new
                        {
                            DistrictId = 15,
                            CityId = 4,
                            Name = "Carmes"
                        },
                        new
                        {
                            DistrictId = 16,
                            CityId = 4,
                            Name = "Saint-Étienne"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfExpense")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ExpenseTypeId");

                    b.HasIndex("UnitId");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("DataAccess.Entities.ExpenseType", b =>
                {
                    b.Property<int>("ExpenseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseTypeId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseTypeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ExpenseType");

                    b.HasData(
                        new
                        {
                            ExpenseTypeId = 1,
                            CategoryId = 1,
                            Name = "Achat - Tapioca"
                        },
                        new
                        {
                            ExpenseTypeId = 2,
                            CategoryId = 1,
                            Name = "Achat - Arachide"
                        },
                        new
                        {
                            ExpenseTypeId = 3,
                            CategoryId = 1,
                            Name = "Achat - Sucre"
                        },
                        new
                        {
                            ExpenseTypeId = 4,
                            CategoryId = 2,
                            Name = "transport - Tapioca"
                        },
                        new
                        {
                            ExpenseTypeId = 5,
                            CategoryId = 2,
                            Name = "transport - Arachide"
                        },
                        new
                        {
                            ExpenseTypeId = 6,
                            CategoryId = 2,
                            Name = "transport - Sucre"
                        },
                        new
                        {
                            ExpenseTypeId = 7,
                            CategoryId = 3,
                            Name = "Déplacement - Prospection"
                        },
                        new
                        {
                            ExpenseTypeId = 8,
                            CategoryId = 3,
                            Name = " Déplacement - Achat Matières premières"
                        },
                        new
                        {
                            ExpenseTypeId = 9,
                            CategoryId = 3,
                            Name = "Déplacement - Dépôt en boutique"
                        },
                        new
                        {
                            ExpenseTypeId = 10,
                            CategoryId = 3,
                            Name = "Déplacement - Envoi de commandes"
                        },
                        new
                        {
                            ExpenseTypeId = 11,
                            CategoryId = 4,
                            Name = "Salaire - Grillage arachides"
                        },
                        new
                        {
                            ExpenseTypeId = 12,
                            CategoryId = 4,
                            Name = "Salaire - Dépulpage arachides"
                        },
                        new
                        {
                            ExpenseTypeId = 13,
                            CategoryId = 4,
                            Name = "Salaire Préparation arachides"
                        },
                        new
                        {
                            ExpenseTypeId = 14,
                            CategoryId = 4,
                            Name = "Salaire - Séchage tapioca"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<DateTime>("CreatingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPayLater")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PayementDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuantityOfBags")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ShopId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DataAccess.Entities.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopId"), 1L, 1);

                    b.Property<DateTime>("CreatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("FirstPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpsLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpsLongigtude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsProspection")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsWhatsappFirstPhone")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsWhatsappSecondPhone")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("ImageId");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("DataAccess.Entities.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnitId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitId");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            UnitId = 1,
                            Name = "Demi-Sac"
                        },
                        new
                        {
                            UnitId = 2,
                            Name = "Sac"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.District", b =>
                {
                    b.HasOne("DataAccess.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DataAccess.Entities.Expense", b =>
                {
                    b.HasOne("DataAccess.Entities.ExpenseType", "ExpenseType")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Unit", "Unit")
                        .WithMany("Expenses")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ExpenseType");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("DataAccess.Entities.ExpenseType", b =>
                {
                    b.HasOne("DataAccess.Entities.Category", "Category")
                        .WithMany("ExpenseTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.HasOne("DataAccess.Entities.Shop", "Shop")
                        .WithMany("Orders")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("DataAccess.Entities.Shop", b =>
                {
                    b.HasOne("DataAccess.Entities.District", "District")
                        .WithMany("Shops")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("District");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Navigation("ExpenseTypes");
                });

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("DataAccess.Entities.District", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("DataAccess.Entities.ExpenseType", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("DataAccess.Entities.Shop", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Unit", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
