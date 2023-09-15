﻿// <auto-generated />
using CQ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQ.Migrations
{
    [DbContext(typeof(CQContext))]
    partial class CQContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CQ.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BasketballPoints");

                    b.Property<int>("BirthDay");

                    b.Property<int>("FootVolleyPoints");

                    b.Property<int>("Goal");

                    b.Property<double>("Height");

                    b.Property<string>("Name");

                    b.Property<int>("VolleyballPoints");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}