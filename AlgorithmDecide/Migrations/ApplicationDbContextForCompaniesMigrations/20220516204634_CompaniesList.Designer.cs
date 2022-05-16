﻿// <auto-generated />
using System;
using AlgorithmDecide.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlgorithmDecide.Migrations.ApplicationDbContextForCompaniesMigrations
{
    [DbContext(typeof(ApplicationDbContextForCompanies))]
    [Migration("20220516204634_CompaniesList")]
    partial class CompaniesList
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AlgorithmDecide.Models.CompaniesInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfOrigin")
                        .HasColumnType("Data");

                    b.Property<float>("Evalutation")
                        .HasColumnType("real");

                    b.Property<float>("StockPrice")
                        .HasColumnType("real");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
