﻿// <auto-generated />
using FootballApp.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FootballApp.Api.Migrations
{
    [DbContext(typeof(FootballAppContext))]
    partial class FootballAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballApp.Api.Models.PostedLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("PostedLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
