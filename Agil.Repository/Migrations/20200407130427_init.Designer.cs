﻿// <auto-generated />
using System;
using Agil.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agil.Repository.Migrations
{
    [DbContext(typeof(AgilContext))]
    [Migration("20200407130427_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Agil.Domain.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataEvento");

                    b.Property<string>("Email");

                    b.Property<string>("ImagemURL");

                    b.Property<string>("Local");

                    b.Property<int>("QtdPessoas");

                    b.Property<string>("Telefone");

                    b.Property<string>("Tema");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Agil.Domain.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<int>("EventoId");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("Agil.Domain.Palestrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("ImagemURL");

                    b.Property<string>("MiniCurriculo");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Palestrantes");
                });

            modelBuilder.Entity("Agil.Domain.PalestranteEvento", b =>
                {
                    b.Property<int>("EventoId");

                    b.Property<int>("PalestranteId");

                    b.HasKey("EventoId", "PalestranteId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("PalestranteEventos");
                });

            modelBuilder.Entity("Agil.Domain.RedeSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventoId");

                    b.Property<string>("Nome");

                    b.Property<int?>("PalestranteId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("RedeSociais");
                });

            modelBuilder.Entity("Agil.Domain.Lote", b =>
                {
                    b.HasOne("Agil.Domain.Evento", "Evento")
                        .WithMany("Lotes")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agil.Domain.PalestranteEvento", b =>
                {
                    b.HasOne("Agil.Domain.Evento", "Evento")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Agil.Domain.Palestrante", "Palestrante")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agil.Domain.RedeSocial", b =>
                {
                    b.HasOne("Agil.Domain.Evento", "Evento")
                        .WithMany("RedeSociais")
                        .HasForeignKey("EventoId");

                    b.HasOne("Agil.Domain.Palestrante", "Palestrante")
                        .WithMany("RedeSociais")
                        .HasForeignKey("PalestranteId");
                });
#pragma warning restore 612, 618
        }
    }
}
