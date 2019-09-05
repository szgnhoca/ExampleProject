﻿// <auto-generated />
using System;
using EP.Project.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EP.Project.DataAccess.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20190904235037_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EP.Project.Entities.Article", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SubjectID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("EP.Project.Entities.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EP.Project.Entities.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EP.Project.Entities.Article", b =>
                {
                    b.HasOne("EP.Project.Entities.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EP.Project.Entities.Subject", "Subject")
                        .WithMany("Articles")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}