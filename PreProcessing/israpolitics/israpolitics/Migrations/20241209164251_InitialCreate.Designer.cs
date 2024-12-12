﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using israpolitics.Model;

#nullable disable

namespace israpolitics.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241209164251_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("israpolitics.Model.KnessetSpeeches.KnessetSpeech", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("Chair")
                        .HasColumnType("INTEGER")
                        .HasColumnName("chair");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("date");

                    b.Property<int>("Knesset")
                        .HasColumnType("INTEGER")
                        .HasColumnName("knesset");

                    b.Property<int?>("NameId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("name_id");

                    b.Property<bool?>("OnlyRead")
                        .HasColumnType("INTEGER")
                        .HasColumnName("only_read");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("person_id");

                    b.Property<bool?>("Qa")
                        .HasColumnType("INTEGER")
                        .HasColumnName("qa");

                    b.Property<string>("Query")
                        .HasColumnType("TEXT")
                        .HasColumnName("query");

                    b.Property<long?>("SessionNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("session_number");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT")
                        .HasColumnName("text");

                    b.Property<int?>("TopicExtraId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("topic_extra_id");

                    b.Property<int?>("TopicId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("topic_id");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.HasIndex("TopicExtraId");

                    b.HasIndex("TopicId");

                    b.ToTable("knesset_speeches", (string)null);
                });

            modelBuilder.Entity("israpolitics.Model.KnessetSpeeches.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("String")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("String")
                        .IsUnique();

                    b.ToTable("names", (string)null);
                });

            modelBuilder.Entity("israpolitics.Model.KnessetSpeeches.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("String")
                        .HasColumnType("TEXT")
                        .HasColumnName("topic");

                    b.HasKey("Id");

                    b.HasIndex("String")
                        .IsUnique();

                    b.ToTable("topics", (string)null);
                });

            modelBuilder.Entity("israpolitics.Model.KnessetSpeeches.TopicExtra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("String")
                        .HasColumnType("TEXT")
                        .HasColumnName("topic_extra");

                    b.HasKey("Id");

                    b.HasIndex("String")
                        .IsUnique();

                    b.ToTable("topic_extras", (string)null);
                });

            modelBuilder.Entity("israpolitics.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasColumnName("city");

                    b.Property<string>("Cob")
                        .HasColumnType("TEXT")
                        .HasColumnName("cob");

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("TEXT")
                        .HasColumnName("dob");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("end_date");

                    b.Property<string>("Faction")
                        .HasColumnType("TEXT")
                        .HasColumnName("faction");

                    b.Property<int?>("FactionId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("faction_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<bool>("Gender")
                        .HasColumnType("INTEGER")
                        .HasColumnName("gender");

                    b.Property<int?>("Knesset")
                        .HasColumnType("INTEGER")
                        .HasColumnName("knesset");

                    b.Property<string>("Languages")
                        .HasColumnType("TEXT")
                        .HasColumnName("languages");

                    b.Property<string>("PartyName")
                        .HasColumnType("TEXT")
                        .HasColumnName("party_name");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("person_id");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("start_date");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("surname");

                    b.Property<int?>("Yod")
                        .HasColumnType("INTEGER")
                        .HasColumnName("yod");

                    b.Property<int?>("Yoi")
                        .HasColumnType("INTEGER")
                        .HasColumnName("yoi");

                    b.HasKey("Id");

                    b.ToTable("people", (string)null);
                });

            modelBuilder.Entity("israpolitics.Model.KnessetSpeeches.KnessetSpeech", b =>
                {
                    b.HasOne("israpolitics.Model.KnessetSpeeches.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId");

                    b.HasOne("israpolitics.Model.KnessetSpeeches.TopicExtra", "TopicExtra")
                        .WithMany()
                        .HasForeignKey("TopicExtraId");

                    b.HasOne("israpolitics.Model.KnessetSpeeches.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");

                    b.Navigation("Name");

                    b.Navigation("Topic");

                    b.Navigation("TopicExtra");
                });
#pragma warning restore 612, 618
        }
    }
}
