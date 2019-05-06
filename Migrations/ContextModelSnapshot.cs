﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Models;

namespace server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("server.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId");

                    b.Property<bool>("IsBlocked");

                    b.Property<int>("Quantity")
                        .IsConcurrencyToken();

                    b.Property<int>("Value")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Coins");
                });

            modelBuilder.Entity("server.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminCode");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("server.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId");

                    b.Property<string>("Name");

                    b.Property<int>("Price")
                        .IsConcurrencyToken();

                    b.Property<int>("Quantity")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("server.Models.Coin", b =>
                {
                    b.HasOne("server.Models.Device", "Device")
                        .WithMany("Coins")
                        .HasForeignKey("DeviceId");
                });

            modelBuilder.Entity("server.Models.Drink", b =>
                {
                    b.HasOne("server.Models.Device", "Device")
                        .WithMany("Drinks")
                        .HasForeignKey("DeviceId");
                });
#pragma warning restore 612, 618
        }
    }
}
