﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using userapi.Domain;

#nullable disable

namespace Webcrawl_if20b032.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Webcrawl_if20b032.Domain.Users.UserHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<List<string>>("foundpdfs")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("foundpdfs");

                    b.Property<List<string>>("searchedurls")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("searchedurls");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("time");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("id");

                    b.ToTable("userhistory");
                });

            modelBuilder.Entity("userapi.Domain.Users.User", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("nickname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("pw");

                    b.HasKey("email");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
