﻿// <auto-generated />
using FirstEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FirstEFCore.Migrations
{
    [DbContext(typeof(DogContext))]
    [Migration("20180410090744_AddedMonkeyToDog")]
    partial class AddedMonkeyToDog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirstEFCore.Models.Dog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsThief");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}
