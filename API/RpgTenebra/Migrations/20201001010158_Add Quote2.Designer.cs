﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgTenebra.Models;

namespace RpgTenebra.Migrations
{
    [DbContext(typeof(TenebraContext))]
    [Migration("20201001010158_Add Quote2")]
    partial class AddQuote2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.Chapter", b =>
                {
                    b.Property<int>("ChapterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.HasKey("ChapterId");

                    b.HasIndex("QuoteId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.GlosseryOfTheDamned", b =>
                {
                    b.Property<int>("GodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(750)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GodId");

                    b.ToTable("GlosseryOfTheDamned");
                });

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("varchar(2500)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.Row", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("varchar(2000)");

                    b.HasKey("RowId");

                    b.HasIndex("QuoteId");

                    b.ToTable("Rows");
                });

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.Chapter", b =>
                {
                    b.HasOne("RpgTenebra.Models.VampireM5.Quote", "Quote")
                        .WithMany()
                        .HasForeignKey("QuoteId");
                });

            modelBuilder.Entity("RpgTenebra.Models.VampireM5.Row", b =>
                {
                    b.HasOne("RpgTenebra.Models.VampireM5.Quote", null)
                        .WithMany("Rows")
                        .HasForeignKey("QuoteId");
                });
#pragma warning restore 612, 618
        }
    }
}
