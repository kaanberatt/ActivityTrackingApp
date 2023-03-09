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
    [Migration("20230309185531_Mig_AddedGenderinAppUser")]
    partial class Mig_AddedGenderinAppUser
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

                    b.Property<string>("Gender")
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
                            Gender = "Erkek",
                            IsActived = true,
                            LastName = "Tokat",
                            PasswordHash = new byte[] { 23, 45, 32, 249, 66, 94, 129, 239, 227, 70, 70, 183, 173, 19, 155, 226, 66, 185, 69, 121, 6, 8, 22, 168, 48, 73, 239, 57, 18, 209, 95, 142, 245, 47, 239, 168, 222, 7, 226, 157, 130, 131, 37, 250, 66, 57, 3, 181, 11, 210, 1, 34, 143, 96, 25, 2, 105, 149, 191, 130, 128, 157, 105, 121 },
                            PasswordSalt = new byte[] { 174, 62, 107, 170, 59, 27, 43, 233, 173, 44, 59, 30, 89, 55, 46, 199, 232, 136, 50, 112, 29, 119, 218, 48, 227, 125, 146, 220, 11, 223, 199, 107, 54, 247, 153, 100, 242, 226, 165, 95, 109, 87, 152, 61, 5, 126, 138, 110, 39, 197, 187, 90, 184, 218, 92, 29, 107, 0, 198, 45, 250, 157, 94, 141, 65, 103, 40, 234, 0, 182, 244, 151, 196, 189, 180, 167, 249, 36, 47, 122, 17, 0, 183, 199, 22, 182, 168, 36, 155, 112, 78, 16, 78, 63, 223, 177, 118, 146, 96, 157, 202, 197, 82, 51, 125, 45, 240, 234, 206, 105, 180, 149, 127, 49, 182, 108, 91, 169, 19, 44, 84, 165, 145, 8, 247, 213, 223, 207 },
                            Phone = "05348952284",
                            PhoneNumberConfirmed = true,
                            Role = "User",
                            Tc = "31112554896",
                            TokenExpiryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            createdDate = new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4952)
                        });
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            createdDate = new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4745)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilim-Kurgu",
                            createdDate = new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4757)
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
                            createdDate = new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4874)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dinleme",
                            createdDate = new DateTime(2023, 3, 9, 21, 55, 30, 844, DateTimeKind.Local).AddTicks(4875)
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

                    b.Property<int>("EventTopicId")
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

                    b.HasIndex("EventTopicId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("ActivityTrackingApp.Entities.Concrete.Event", b =>
                {
                    b.HasOne("ActivityTrackingApp.Entities.Concrete.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

                    b.HasOne("ActivityTrackingApp.Entities.Concrete.EventTopic", "EventTopic")
                        .WithMany()
                        .HasForeignKey("EventTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Event");

                    b.Navigation("EventTopic");
                });
#pragma warning restore 612, 618
        }
    }
}