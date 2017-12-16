﻿// <auto-generated />
using Data.Persistence.ApplicationUserDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Data.Persistence.Migrations.ContentDb
{
    [DbContext(typeof(ContentDbContext))]
    partial class ContentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Domain.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("PublishDate");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}