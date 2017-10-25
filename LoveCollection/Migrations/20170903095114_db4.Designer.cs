﻿// <auto-generated />
using LoveCollection.EntityFramework.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LoveCollection.Migrations
{
    [DbContext(typeof(CollectionDBCotext))]
    [Migration("20170903095114_db4")]
    partial class db4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("LoveCollection.Entities.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Sort");

                    b.Property<int?>("TagId");

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<int>("TypeId");

                    b.Property<string>("Url")
                        .HasMaxLength(300);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("LoveCollection.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("LoveCollection.Entities.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<double>("Sort");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("LoveCollection.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime>("LastOnlineTime");

                    b.Property<string>("Mail")
                        .HasMaxLength(50);

                    b.Property<string>("Passwod")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LoveCollection.Entities.Collection", b =>
                {
                    b.HasOne("LoveCollection.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.HasOne("LoveCollection.Entities.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LoveCollection.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LoveCollection.Entities.Tag", b =>
                {
                    b.HasOne("LoveCollection.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LoveCollection.Entities.Type", b =>
                {
                    b.HasOne("LoveCollection.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
