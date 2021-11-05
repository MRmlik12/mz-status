﻿// <auto-generated />
using System;
using MZCovidBot.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MZCovidBot.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211105211440_SendCovidStats")]
    partial class SendCovidStats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MZCovidBot.Database.Entities.CovidData", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<long>("DailyDeceased")
                        .HasColumnType("bigint");

                    b.Property<long>("DailyInfected")
                        .HasColumnType("bigint");

                    b.Property<long>("DailyPositiveTests")
                        .HasColumnType("bigint");

                    b.Property<long>("DailyQuarantine")
                        .HasColumnType("bigint");

                    b.Property<long>("DailyRecovered")
                        .HasColumnType("bigint");

                    b.Property<long>("DailyTested")
                        .HasColumnType("bigint");

                    b.Property<long>("Deceased")
                        .HasColumnType("bigint");

                    b.Property<string>("HistoryData")
                        .HasColumnType("text");

                    b.Property<long>("Infected")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("LastUpdatedAtApify")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("LastUpdatedAtSource")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Recovered")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("text");

                    b.Property<string>("TxtDate")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CovidData");
                });
#pragma warning restore 612, 618
        }
    }
}
