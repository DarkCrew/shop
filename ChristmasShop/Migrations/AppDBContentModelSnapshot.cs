﻿// <auto-generated />
using System;
using ChristmasShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChristmasShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChristmasShop.Data.Models.CategoryTree", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("CategoryTree");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("orderTime");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TreeID");

                    b.Property<int>("orderID");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("TreeID");

                    b.HasIndex("orderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int>("price");

                    b.Property<int?>("treeid");

                    b.HasKey("id");

                    b.HasIndex("treeid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.Tree", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryTreeid");

                    b.Property<int>("categoryID");

                    b.Property<string>("img");

                    b.Property<bool>("isAvailable");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("CategoryTreeid");

                    b.ToTable("Tree");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("ChristmasShop.Data.Models.Tree", "tree")
                        .WithMany()
                        .HasForeignKey("TreeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ChristmasShop.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("ChristmasShop.Data.Models.Tree", "tree")
                        .WithMany()
                        .HasForeignKey("treeid");
                });

            modelBuilder.Entity("ChristmasShop.Data.Models.Tree", b =>
                {
                    b.HasOne("ChristmasShop.Data.Models.CategoryTree", "CategoryTree")
                        .WithMany("trees")
                        .HasForeignKey("CategoryTreeid");
                });
#pragma warning restore 612, 618
        }
    }
}
