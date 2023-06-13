﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.EFCDataAccess;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230613080149_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("WebApi.Models.Players", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsThisSeason")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.Property<int>("ShirtNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamsTeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeamsTeamName");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WebApi.Models.Teams", b =>
                {
                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameOfCoach")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Ranking")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamName");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("WebApi.Models.Players", b =>
                {
                    b.HasOne("WebApi.Models.Teams", null)
                        .WithMany("PlayersCollection")
                        .HasForeignKey("TeamsTeamName");
                });

            modelBuilder.Entity("WebApi.Models.Teams", b =>
                {
                    b.Navigation("PlayersCollection");
                });
#pragma warning restore 612, 618
        }
    }
}