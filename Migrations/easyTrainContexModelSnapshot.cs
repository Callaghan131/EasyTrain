﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gabrielli.gianmarco._5i.EasyTrain;

namespace gabrielli.gianmarco._5i.EasyTrain.Migrations
{
    [DbContext(typeof(easyTrainContex))]
    partial class easyTrainContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("gabrielli.gianmarco._5i.EasyTrain.Film", b =>
                {
                    b.Property<int>("Filmid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnoProduzione");

                    b.Property<string>("BreveTrama");

                    b.Property<int>("Durata");

                    b.Property<int>("Genere");

                    b.Property<string>("Titolo");

                    b.HasKey("Filmid");

                    b.ToTable("films");
                });

            modelBuilder.Entity("gabrielli.gianmarco._5i.EasyTrain.Utente", b =>
                {
                    b.Property<int>("Utenteid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cognome");

                    b.Property<string>("Nome");

                    b.HasKey("Utenteid");

                    b.ToTable("utenti");
                });
#pragma warning restore 612, 618
        }
    }
}
