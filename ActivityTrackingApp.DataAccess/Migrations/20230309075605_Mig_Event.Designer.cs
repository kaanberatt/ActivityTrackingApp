﻿// <auto-generated />
using System;
using ActivityTrackingApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ActivityTrackingApp.DataAccess.Migrations
{
    [DbContext(typeof(ActivityTrackingDbContext))]
    [Migration("20230309075605_Mig_Event")]
    partial class Mig_Event
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Age = 30,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Sakarya",
                            Education = "Üniversite",
                            Email = "kaan@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kaan Berat",
                            IsActived = true,
                            LastName = "Tokat",
                            PasswordHash = new byte[] { 13, 140, 78, 16, 142, 24, 254, 155, 205, 50, 132, 128, 143, 214, 238, 57, 238, 87, 80, 154, 42, 135, 240, 189, 67, 119, 41, 3, 119, 0, 136, 30, 207, 146, 228, 107, 127, 45, 129, 197, 202, 217, 211, 175, 102, 229, 16, 44, 250, 57, 183, 25, 190, 83, 5, 127, 215, 67, 123, 188, 113, 137, 152, 216 },
                            PasswordSalt = new byte[] { 87, 240, 50, 174, 98, 137, 18, 75, 48, 34, 129, 100, 198, 42, 165, 187, 9, 144, 123, 67, 219, 16, 84, 186, 65, 161, 38, 116, 125, 134, 91, 154, 188, 89, 58, 1, 52, 48, 214, 35, 116, 124, 135, 198, 252, 32, 79, 114, 251, 10, 5, 94, 187, 215, 241, 52, 239, 114, 183, 196, 137, 250, 170, 113, 97, 160, 246, 187, 125, 93, 135, 74, 94, 42, 185, 99, 210, 80, 241, 230, 84, 250, 122, 218, 21, 198, 221, 242, 224, 93, 100, 157, 131, 111, 63, 134, 154, 92, 246, 123, 216, 255, 230, 244, 85, 224, 197, 100, 7, 197, 0, 29, 174, 157, 21, 162, 84, 109, 17, 8, 46, 252, 203, 255, 247, 165, 77, 131 },
                            Phone = "05348952284",
                            PhoneNumberConfirmed = true,
                            Role = "User",
                            Tc = "31112554896",
                            TokenExpiryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            createdDate = new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(866)
                        });
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EventTopicId")
                        .HasColumnType("int");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventTopicId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.EventTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EventTopics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Aksiyon",
                            createdDate = new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(687)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilim-Kurgu",
                            createdDate = new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(698)
                        });
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Okuma",
                            createdDate = new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(800)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dinleme",
                            createdDate = new DateTime(2023, 3, 9, 10, 56, 4, 990, DateTimeKind.Local).AddTicks(801)
                        });
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.UserActivities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("EventId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.Event", b =>
                {
                    b.HasOne("ActivityTrackingApp.Entities.Concrete.EventTopic", "EventTopic")
                        .WithMany()
                        .HasForeignKey("EventTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ActivityTrackingApp.Entities.Concrete.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventTopic");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.UserActivities", b =>
                {
                    b.HasOne("ActivityTrackingApp.Entities.Concrete.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ActivityTrackingApp.Entities.Concrete.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}