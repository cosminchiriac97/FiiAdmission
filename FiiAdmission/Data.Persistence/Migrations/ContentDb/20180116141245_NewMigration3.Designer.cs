﻿// <auto-generated />
using Data.Persistence.ContentDb;
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
    [Migration("20180116141245_NewMigration3")]
    partial class NewMigration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Data.Domain.AnswerToAdmissionForm", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Reason");

                    b.Property<string>("Status");

                    b.HasKey("Email");

                    b.ToTable("AnswerToAdmissionForms");
                });

            modelBuilder.Entity("Data.Domain.Candidate", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<string>("CNP");

                    b.Property<bool>("Completed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("School");

                    b.Property<string>("Subject");

                    b.HasKey("Email");

                    b.ToTable("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}