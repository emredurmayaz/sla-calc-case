﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SLACalculation.Database;

namespace SLACalculation.Migrations
{
    [DbContext(typeof(SLACalcContext))]
    [Migration("20201228121332_Added-InitTables")]
    partial class AddedInitTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SLACalculation.Database.Complaint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComplaintTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ResolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComplaintTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("SLACalculation.Database.ComplaintType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ComplaintType");
                });

            modelBuilder.Entity("SLACalculation.Database.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Segment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SLACalculation.Database.Complaint", b =>
                {
                    b.HasOne("SLACalculation.Database.ComplaintType", "ComplaintType")
                        .WithMany("Complaints")
                        .HasForeignKey("ComplaintTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SLACalculation.Database.Customer", "Customer")
                        .WithMany("Complaints")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplaintType");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SLACalculation.Database.ComplaintType", b =>
                {
                    b.Navigation("Complaints");
                });

            modelBuilder.Entity("SLACalculation.Database.Customer", b =>
                {
                    b.Navigation("Complaints");
                });
#pragma warning restore 612, 618
        }
    }
}
