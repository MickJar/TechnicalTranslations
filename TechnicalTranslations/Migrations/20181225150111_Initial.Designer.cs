﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalTranslations.Models;

namespace TechnicalTranslations.Migrations
{
    [DbContext(typeof(TechnicalTranslationsContext))]
    [Migration("20181225150111_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechnicalTranslations.Models.Word", b =>
                {
                    b.Property<string>("Original")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Translation");

                    b.HasKey("Original");

                    b.ToTable("Word");
                });
#pragma warning restore 612, 618
        }
    }
}
