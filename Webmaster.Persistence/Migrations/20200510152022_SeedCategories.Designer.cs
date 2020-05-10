﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webmaster.Persistence;

namespace Webmaster.Persistence.Migrations
{
    [DbContext(typeof(WebmasterDbContext))]
    [Migration("20200510152022_SeedCategories")]
    partial class SeedCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Webmaster.Application.Domain.Entities.Website", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Website");
                });

            modelBuilder.Entity("Webmaster.Application.Domain.Entities.WebsiteCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("WebsiteCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Arts and Entertainment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Business and Consumer Services"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Community and Society"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Computers Electronics and Technology"
                        },
                        new
                        {
                            Id = 5,
                            Name = "E commerce and Shopping"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Food and Drink"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gambling"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Health"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Hobbies and Leisure"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Home and Garden"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Jobs and Career"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Law and Government"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Lifestyle"
                        },
                        new
                        {
                            Id = 16,
                            Name = "News and Media"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Pets and Animals"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Reference Materials"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Science and Education"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Travel and Tourism"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Vehicles"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Adult"
                        });
                });

            modelBuilder.Entity("Webmaster.Application.Domain.Entities.Website", b =>
                {
                    b.HasOne("Webmaster.Application.Domain.Entities.WebsiteCategory", "Category")
                        .WithMany("Websites")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
