﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestRegister.Data;

#nullable disable

namespace TestRegister.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestRegister.Models.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoPlace")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("TestRegister.Models.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("AwardPhoto1")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("AwardPhoto2")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("AwardProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("TestRegister.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("E_mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TestRegister.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Accessibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bathroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bedroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cleaning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Food")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontDeskServices")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kitchen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LivingArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parking")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomAmenities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Safty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transportation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("TestRegister.Models.ManagerData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("NationalId")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("NationalId2")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ManagerDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
