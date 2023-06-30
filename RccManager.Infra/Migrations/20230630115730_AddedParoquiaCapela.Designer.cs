﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RccManager.Infra.Context;

namespace RccManager.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230630115730_AddedParoquiaCapela")]
    partial class AddedParoquiaCapela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RccManager.Domain.Entities.DecanatoSetor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnName("active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnName("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Decanatos");
                });

            modelBuilder.Entity("RccManager.Domain.Entities.ParoquiaCapela", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnName("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("bairro")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("cidade")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnName("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DecanatoId")
                        .HasColumnName("decanatoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnName("endereco")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DecanatoId");

                    b.ToTable("ParoquiasCapelas");
                });

            modelBuilder.Entity("RccManager.Domain.Entities.ParoquiaCapela", b =>
                {
                    b.HasOne("RccManager.Domain.Entities.DecanatoSetor", "DecanatoSetor")
                        .WithMany()
                        .HasForeignKey("DecanatoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
