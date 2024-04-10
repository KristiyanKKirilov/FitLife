﻿// <auto-generated />
using System;
using FitLife.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitLife.Data.Migrations
{
    [DbContext(typeof(FitLifeDbContext))]
    [Migration("20240410180930_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitLife.Data.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Event's identifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Event's address in detail described");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Event's category identifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasComment("Event's city");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Event's creator identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Event's description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Event's image url");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Event's state");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2")
                        .HasComment("Event's start time in format dd/MM/yyyy hh:mm");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Event's title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Events");

                    b.HasComment("Events");
                });

            modelBuilder.Entity("FitLife.Data.Models.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Event category's identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Event category's state");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Event category's name");

                    b.HasKey("Id");

                    b.ToTable("EventCategories");

                    b.HasComment("EventCategories");
                });

            modelBuilder.Entity("FitLife.Data.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Order identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Order's state");

                    b.Property<string>("ParticipantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Order's participant identifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Order's total price");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Orders");

                    b.HasComment("Orders");
                });

            modelBuilder.Entity("FitLife.Data.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasComment("Participant's living town");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Participant's first name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Participant's state");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Participant's last name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("Participants");
                });

            modelBuilder.Entity("FitLife.Data.Models.ParticipantEvent", b =>
                {
                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Participant's identifier");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Event's identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Order's state");

                    b.HasKey("ParticipantId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("ParticipantEvent");

                    b.HasComment("ParticipantsEvents");
                });

            modelBuilder.Entity("FitLife.Data.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Product's identifier");

                    b.Property<int>("AvailableStockCount")
                        .HasColumnType("int")
                        .HasComment("Product's available count in storage");

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasComment("Product's count in a participant's order");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Product's nutrition described");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit")
                        .HasComment("Product's state");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Product's state");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Product's name");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product's price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasComment("Products");
                });

            modelBuilder.Entity("FitLife.Data.Models.Trainer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Trainer's identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Trainer's email address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Trainer's first name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Trainer's state");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Trainer's last name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Trainer's user identifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trainers");

                    b.HasComment("Trainers");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainerEvent", b =>
                {
                    b.Property<string>("TrainerId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Trainer's identifier");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Event's identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Order's state");

                    b.HasKey("TrainerId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("TrainersEvents");

                    b.HasComment("TrainersEvents");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgram", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Training program's identifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Training program's category identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Training program's creator");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Training program's description");

                    b.Property<int>("DurationDays")
                        .HasColumnType("int")
                        .HasComment("Training program's duration in days");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Training program's image url");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Training program's state");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("Training program's date of start in format dd/MM/yyyy hh:mm");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Training program's title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("TrainingPrograms");

                    b.HasComment("TrainingPrograms");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("TrainingProgram category's identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Training program category's state");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("TrainingProgram category's name");

                    b.HasKey("Id");

                    b.ToTable("TrainingProgramCategories");

                    b.HasComment("TrainingProgramCategories");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramParticipant", b =>
                {
                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Participant's identifier");

                    b.Property<string>("TrainingProgramId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Training program's identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("TrainingProgramParticipant's state");

                    b.HasKey("ParticipantId", "TrainingProgramId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramParticipant");

                    b.HasComment("TrainingProgramsParticipants");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramTrainer", b =>
                {
                    b.Property<string>("TrainerId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Trainer's identifier");

                    b.Property<string>("TrainingProgramId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Training program's identifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Time of creation");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("TrainingProgramsTrainers state");

                    b.HasKey("TrainerId", "TrainingProgramId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramsTrainers");

                    b.HasComment("TrainingProgramsTrainers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitLife.Data.Models.Event", b =>
                {
                    b.HasOne("FitLife.Data.Models.EventCategory", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.Trainer", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("FitLife.Data.Models.Order", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", "Participant")
                        .WithMany("Orders")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("FitLife.Data.Models.ParticipantEvent", b =>
                {
                    b.HasOne("FitLife.Data.Models.Event", "Event")
                        .WithMany("ParticipantsEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.Participant", "Participant")
                        .WithMany("ParticipantsEvents")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("FitLife.Data.Models.Product", b =>
                {
                    b.HasOne("FitLife.Data.Models.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("FitLife.Data.Models.Trainer", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainerEvent", b =>
                {
                    b.HasOne("FitLife.Data.Models.Event", "Event")
                        .WithMany("TrainersEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.Trainer", "Trainer")
                        .WithMany("TrainersEvents")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgram", b =>
                {
                    b.HasOne("FitLife.Data.Models.TrainingProgramCategory", "Category")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.Trainer", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramParticipant", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", "Participant")
                        .WithMany("TrainingProgramsParticipants")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.TrainingProgram", "TrainingProgram")
                        .WithMany("TrainingProgramsParticipants")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramTrainer", b =>
                {
                    b.HasOne("FitLife.Data.Models.Trainer", "Trainer")
                        .WithMany("TrainingProgramsTrainers")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.TrainingProgram", "TrainingProgram")
                        .WithMany("TrainingProgramsTrainers")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Trainer");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitLife.Data.Models.Participant", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FitLife.Data.Models.Participant", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitLife.Data.Models.Event", b =>
                {
                    b.Navigation("ParticipantsEvents");

                    b.Navigation("TrainersEvents");
                });

            modelBuilder.Entity("FitLife.Data.Models.EventCategory", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("FitLife.Data.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FitLife.Data.Models.Participant", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ParticipantsEvents");

                    b.Navigation("TrainingProgramsParticipants");
                });

            modelBuilder.Entity("FitLife.Data.Models.Trainer", b =>
                {
                    b.Navigation("TrainersEvents");

                    b.Navigation("TrainingProgramsTrainers");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgram", b =>
                {
                    b.Navigation("TrainingProgramsParticipants");

                    b.Navigation("TrainingProgramsTrainers");
                });

            modelBuilder.Entity("FitLife.Data.Models.TrainingProgramCategory", b =>
                {
                    b.Navigation("TrainingPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
