﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WiProTest.Infra.Data.Context;

namespace WiProTest.Infra.Data.Migrations
{
    [DbContext(typeof(WiProTestContext))]
    [Migration("20201227035437_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("WiProTest.Domain.Entities.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("data_cadastro")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("lotes");
                });

            modelBuilder.Entity("WiProTest.Domain.Entities.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnName("data_fim")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnName("data_inicio")
                        .HasColumnType("datetime");

                    b.Property<int>("IdLote")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeMoeda")
                        .IsRequired()
                        .HasColumnName("moeda")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("IdLote");

                    b.ToTable("moedas");
                });

            modelBuilder.Entity("WiProTest.Domain.Entities.Moeda", b =>
                {
                    b.HasOne("WiProTest.Domain.Entities.Lote", "Lote")
                        .WithMany("Moedas")
                        .HasForeignKey("IdLote")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}