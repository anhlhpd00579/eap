﻿// <auto-generated />
using Exam_Q1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exam_Q1.Migrations
{
    [DbContext(typeof(Exam_Q1Context))]
    partial class Exam_Q1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam_Q1.Model.Currency", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Ratio");

                    b.HasKey("Id");

                    b.ToTable("Currency");

                    b.HasData(
                        new { Id = "USD", Ratio = 23260m },
                        new { Id = "EUR", Ratio = 27061m },
                        new { Id = "AUD", Ratio = 16798m },
                        new { Id = "JPY", Ratio = 20704m }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
