﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220612171114_m9")]
    partial class m9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AdminStatus")
                        .HasColumnType("bit");

                    b.Property<string>("AdminUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BlogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WriterID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("WriterID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("BlogID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contactt", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryISO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryISO3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryNName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryNumCode")
                        .HasColumnType("int");

                    b.Property<int>("CountryPhoneCode")
                        .HasColumnType("int");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EntityLayer.Concrete.League", b =>
                {
                    b.Property<int>("LeagueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeagueDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueFoundationYear")
                        .HasColumnType("int");

                    b.Property<string>("LeagueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueTeamCount")
                        .HasColumnType("int");

                    b.Property<int>("LeagueValue")
                        .HasColumnType("int");

                    b.HasKey("LeagueID");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("LeagueID")
                        .HasColumnType("int");

                    b.Property<int>("PlayerAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlayerBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlayerClub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerHeight")
                        .HasColumnType("int");

                    b.Property<string>("PlayerManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("int");

                    b.Property<string>("PlayerPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerPositionISO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PlayerStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PlayerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerValue")
                        .HasColumnType("int");

                    b.Property<int>("PlayerWeight")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("PlayerID");

                    b.HasIndex("CountryID");

                    b.HasIndex("LeagueID");

                    b.HasIndex("SkillID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AerialDuelsLost")
                        .HasColumnType("int");

                    b.Property<int>("AerialDuelsWon")
                        .HasColumnType("int");

                    b.Property<int>("Assist")
                        .HasColumnType("int");

                    b.Property<int>("BBC")
                        .HasColumnType("int");

                    b.Property<int>("BenchMatch")
                        .HasColumnType("int");

                    b.Property<int>("Goal")
                        .HasColumnType("int");

                    b.Property<int>("KeyPass")
                        .HasColumnType("int");

                    b.Property<int>("LongBall")
                        .HasColumnType("int");

                    b.Property<int>("MOTM")
                        .HasColumnType("int");

                    b.Property<int>("Penalties")
                        .HasColumnType("int");

                    b.Property<int>("PossesionLost")
                        .HasColumnType("int");

                    b.Property<int>("PossesionWon")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RedCards")
                        .HasColumnType("int");

                    b.Property<int>("ShootsOffTarget")
                        .HasColumnType("int");

                    b.Property<int>("ShootsOnTarget")
                        .HasColumnType("int");

                    b.Property<string>("SkillPlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartedMatch")
                        .HasColumnType("int");

                    b.Property<int>("SuccesfulDribbling")
                        .HasColumnType("int");

                    b.Property<int>("UnsuccessfulDribbling")
                        .HasColumnType("int");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<int>("LeagueID")
                        .HasColumnType("int");

                    b.Property<string>("TeamCoach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamFoundationYear")
                        .HasColumnType("int");

                    b.Property<string>("TeamImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamPlayerCount")
                        .HasColumnType("int");

                    b.Property<string>("TeamStatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamValue")
                        .HasColumnType("int");

                    b.HasKey("TeamID");

                    b.HasIndex("CountryID");

                    b.HasIndex("LeagueID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("WriterAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WriterBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WriterCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WriterImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("bit");

                    b.Property<string>("WriterSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WriterID");

                    b.HasIndex("CountryID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("WriterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Player", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.League", "League")
                        .WithMany("Players")
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Skill", "Skill")
                        .WithMany("Players")
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("League");

                    b.Navigation("Skill");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("League");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Country", "Country")
                        .WithMany("Writers")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Country", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Teams");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.League", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Skill", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
