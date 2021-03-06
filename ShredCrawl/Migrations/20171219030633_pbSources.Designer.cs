﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShredCrawl.Migrations
{
    [DbContext(typeof(PerpetualShredContext))]
    [Migration("20171219030633_pbSources")]
    partial class PbSources
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShredCrawl.PinkBikeVideoSource", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Source");

                    b.Property<int?>("WebVidId");

                    b.HasKey("Id");

                    b.HasIndex("WebVidId");

                    b.ToTable("PinkBikeVideoSource");
                });

            modelBuilder.Entity("ShredCrawl.WebVid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("OriginTitle");

                    b.Property<string>("OriginUrl");

                    b.Property<string>("PlayerUrl");

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.Property<string>("VideoService");

                    b.HasKey("Id");

                    b.ToTable("WebVid");
                });

            modelBuilder.Entity("ShredCrawl.PinkBikeVideoSource", b =>
                {
                    b.HasOne("ShredCrawl.WebVid")
                        .WithMany("SourceList")
                        .HasForeignKey("WebVidId");
                });
#pragma warning restore 612, 618
        }
    }
}
