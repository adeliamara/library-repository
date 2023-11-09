﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using library.Models;

#nullable disable

namespace library.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231109014248_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("library.Models.Alert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Fine")
                        .HasColumnType("int");

                    b.Property<DateOnly>("IssueDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("ReturnDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("longtext");

                    b.Property<string>("BookName")
                        .HasColumnType("longtext");

                    b.Property<int?>("CatalogId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBooks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.HasIndex("MemberId");

                    b.ToTable("Books");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Book");
                });

            modelBuilder.Entity("library.Models.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfCopies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("library.Models.Librarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("library.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");
                });

            modelBuilder.Entity("library.Models.FacultyMember", b =>
                {
                    b.HasBaseType("library.Models.Member");

                    b.Property<string>("FacultyColl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("FacultyMember");
                });

            modelBuilder.Entity("library.Models.GeneralBook", b =>
                {
                    b.HasBaseType("library.Models.Book");

                    b.HasDiscriminator().HasValue("GeneralBook");
                });

            modelBuilder.Entity("library.Models.ReferenceBook", b =>
                {
                    b.HasBaseType("library.Models.Book");

                    b.HasDiscriminator().HasValue("ReferenceBook");
                });

            modelBuilder.Entity("library.Models.Student", b =>
                {
                    b.HasBaseType("library.Models.Member");

                    b.Property<string>("studentCollege")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("library.Models.Book", b =>
                {
                    b.HasOne("library.Models.Catalog", null)
                        .WithMany("Books")
                        .HasForeignKey("CatalogId");

                    b.HasOne("library.Models.Member", null)
                        .WithMany("Books")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("library.Models.Catalog", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("library.Models.Member", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
