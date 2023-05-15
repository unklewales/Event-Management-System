﻿// <auto-generated />
using Event_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_Management_System.Migrations
{
    [DbContext(typeof(EventMgtSysDBContext))]
    [Migration("20230515142449_eventmodeldeleted")]
    partial class eventmodeldeleted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EventModelRegistration", b =>
                {
                    b.Property<int>("EventModelsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RegistrationsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventModelsId", "RegistrationsId");

                    b.HasIndex("RegistrationsId");

                    b.ToTable("EventModelRegistration");
                });

            modelBuilder.Entity("Event_Management_System.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateOfEvent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EventModels");
                });

            modelBuilder.Entity("Event_Management_System.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("EventModelRegistration", b =>
                {
                    b.HasOne("Event_Management_System.Models.EventModel", null)
                        .WithMany()
                        .HasForeignKey("EventModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_Management_System.Models.Registration", null)
                        .WithMany()
                        .HasForeignKey("RegistrationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
