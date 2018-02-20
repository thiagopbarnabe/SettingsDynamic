﻿// <auto-generated />
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Context.Migrations
{
    [DbContext(typeof(SettingsContext))]
    partial class SettingsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Context.Entities.Setting", b =>
                {
                    b.Property<string>("SettingID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateTimeValue");

                    b.Property<string>("Description");

                    b.Property<int?>("IntegerValue");

                    b.Property<double?>("Numeric4Value");

                    b.Property<string>("StringValue");

                    b.Property<string>("Type");

                    b.HasKey("SettingID");

                    b.ToTable("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
