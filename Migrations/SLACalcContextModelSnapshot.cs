﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SLACalculation.Database;

namespace SLACalculation.Migrations
{
    [DbContext(typeof(SLACalcContext))]
    partial class SLACalcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("9523dcfc-c58e-485d-ba2d-1d0af08830a5"),
                            IsDeleted = false,
                            Name = "ATM Card captured",
                            Priorty = 1
                        },
                        new
                        {
                            Id = new Guid("44247379-ff3d-403e-b9ab-a79b676be656"),
                            IsDeleted = false,
                            Name = "Rude attitude of staff",
                            Priorty = 3
                        },
                        new
                        {
                            Id = new Guid("0bfa4005-0b48-4dc0-b073-9457ba8e8f67"),
                            IsDeleted = false,
                            Name = "Long waiting time in branches",
                            Priorty = 2
                        },
                        new
                        {
                            Id = new Guid("1029b9fe-707d-45a7-be6d-e181a98245bd"),
                            IsDeleted = false,
                            Name = "Disputed transaction in credit card",
                            Priorty = 2
                        },
                        new
                        {
                            Id = new Guid("f988ebef-0ba5-4ccd-80e7-f0e515116448"),
                            IsDeleted = false,
                            Name = "Cash deposited but not reflected in the account",
                            Priorty = 4
                        },
                        new
                        {
                            Id = new Guid("8f4e0a5e-eb39-4354-9c37-00bf31185e9b"),
                            IsDeleted = false,
                            Name = "Credit card application takes too long",
                            Priorty = 4
                        });
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