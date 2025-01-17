﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entity.Entities.categories", b =>
                {
                    b.Property<int>("categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoryname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("categoryid");

                    b.ToTable("kategoriler");
                });

            modelBuilder.Entity("Entity.Entities.product", b =>
                {
                    b.Property<int>("productid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Kategorilercategoryid")
                        .HasColumnType("int");

                    b.Property<string>("productname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stok")
                        .HasColumnType("int");

                    b.HasKey("productid");

                    b.HasIndex("Kategorilercategoryid");

                    b.ToTable("urunler");
                });

            modelBuilder.Entity("Entity.Entities.product", b =>
                {
                    b.HasOne("Entity.Entities.categories", "Kategoriler")
                        .WithMany("urunler")
                        .HasForeignKey("Kategorilercategoryid");

                    b.Navigation("Kategoriler");
                });

            modelBuilder.Entity("Entity.Entities.categories", b =>
                {
                    b.Navigation("urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
