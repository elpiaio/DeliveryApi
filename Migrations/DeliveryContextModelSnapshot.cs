﻿// <auto-generated />
using System;
using DeliveryApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeliveryApi.Migrations
{
    [DbContext(typeof(DeliveryContext))]
    partial class DeliveryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DeliveryApi.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DeliveryApi.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("DeliveryApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("StoreId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DeliveryApi.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("DeliveryApi.Models.Menu", b =>
                {
                    b.HasOne("DeliveryApi.Models.Store", null)
                        .WithMany("Menus")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("DeliveryApi.Models.Produto", b =>
                {
                    b.HasOne("DeliveryApi.Models.Menu", null)
                        .WithMany("Produtos")
                        .HasForeignKey("MenuId");

                    b.HasOne("DeliveryApi.Models.Store", null)
                        .WithMany("Produtos")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("DeliveryApi.Models.Menu", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("DeliveryApi.Models.Store", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
