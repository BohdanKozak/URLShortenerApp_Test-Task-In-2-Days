﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URLShortener.DataAccess.Data;

#nullable disable

namespace URLShortener.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("URLShortener.Models.UrlItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortedUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("UrlItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 8, 10, 13, 7, 12, 608, DateTimeKind.Local).AddTicks(9747),
                            Url = "https://www.youtube.com/watch?v=pQYr1LbVFaM&ab_channel=XGTVUA"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 8, 10, 13, 7, 12, 608, DateTimeKind.Local).AddTicks(9791),
                            Url = "https://open.spotify.com/queue"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 8, 10, 13, 7, 12, 608, DateTimeKind.Local).AddTicks(9793),
                            Url = "https://mail.google.com/mail/u/0/#inbox"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
