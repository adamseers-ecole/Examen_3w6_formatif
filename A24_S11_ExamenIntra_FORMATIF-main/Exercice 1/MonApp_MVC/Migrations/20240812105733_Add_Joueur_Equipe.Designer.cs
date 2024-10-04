﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonApp_MVC.Data;

#nullable disable

namespace MonApp_MVC.Migrations
{
    [DbContext(typeof(MonAppDbContext))]
    [Migration("20240812105733_Add_Joueur_Equipe")]
    partial class Add_Joueur_Equipe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MonApp_MVC.Entities.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proprietaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.FicheOfficielle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biographie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Joueur_Id")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Joueur_Id")
                        .IsUnique();

                    b.ToTable("FicheOfficielles");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Equipe_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Equipe_Id");

                    b.ToTable("Joueurs");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.FicheOfficielle", b =>
                {
                    b.HasOne("MonApp_MVC.Entities.Joueur", "Joueur")
                        .WithOne("FicheOfficielle")
                        .HasForeignKey("MonApp_MVC.Entities.FicheOfficielle", "Joueur_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Joueur");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Joueur", b =>
                {
                    b.HasOne("MonApp_MVC.Entities.Equipe", "Equipe")
                        .WithMany("Joueurs")
                        .HasForeignKey("Equipe_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Equipe", b =>
                {
                    b.Navigation("Joueurs");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Joueur", b =>
                {
                    b.Navigation("FicheOfficielle")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
