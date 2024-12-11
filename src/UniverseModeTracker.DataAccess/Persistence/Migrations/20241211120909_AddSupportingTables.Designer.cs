﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniverseModeTracker.DataAccess.Persistence.Context;

#nullable disable

namespace UniverseModeTracker.DataAccess.Persistence.Migrations
{
    [DbContext(typeof(DefaultDataContext))]
    [Migration("20241211120909_AddSupportingTables")]
    partial class AddSupportingTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Competitor", b =>
                {
                    b.Property<Guid>("SuperstarId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CornerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'SYSTEM'");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsManager")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPinfallScorer")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPinned")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("SuperstarId", "CornerId");

                    b.HasIndex("CornerId");

                    b.ToTable("Competitors");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Corner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'SYSTEM'");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsWinner")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MatchId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Corners");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'SYSTEM'");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ShowId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Show", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'SYSTEM'");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Week")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Superstar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("'SYSTEM'");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("LossCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NoContestCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RingName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<int>("WinCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Superstars");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Competitor", b =>
                {
                    b.HasOne("UniverseModeTracker.Domain.Entities.Corner", "Corner")
                        .WithMany("Competitors")
                        .HasForeignKey("CornerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniverseModeTracker.Domain.Entities.Superstar", "Superstar")
                        .WithMany("Competitors")
                        .HasForeignKey("SuperstarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Corner");

                    b.Navigation("Superstar");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Corner", b =>
                {
                    b.HasOne("UniverseModeTracker.Domain.Entities.Match", "Match")
                        .WithMany("Corners")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Match", b =>
                {
                    b.HasOne("UniverseModeTracker.Domain.Entities.Show", "Show")
                        .WithMany("Matches")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Show", b =>
                {
                    b.HasOne("UniverseModeTracker.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Corner", b =>
                {
                    b.Navigation("Competitors");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Match", b =>
                {
                    b.Navigation("Corners");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Show", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("UniverseModeTracker.Domain.Entities.Superstar", b =>
                {
                    b.Navigation("Competitors");
                });
#pragma warning restore 612, 618
        }
    }
}
