﻿// <auto-generated />
using System;
using Celestia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Celestia.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220518211941_UpdateModel")]
    partial class UpdateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Celestia.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_accounts");

                    b.ToTable("accounts", (string)null);
                });

            modelBuilder.Entity("Celestia.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("IconUrl")
                        .HasColumnType("text")
                        .HasColumnName("icon_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("name");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("text")
                        .HasColumnName("website_url");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_companies_author_id");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("Celestia.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("pk_contacts");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_contacts_author_id");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_contacts_company_id");

                    b.ToTable("contacts", (string)null);
                });

            modelBuilder.Entity("Celestia.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_folders");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_folders_author_id");

                    b.ToTable("folders", (string)null);
                });

            modelBuilder.Entity("Celestia.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int?>("FolderId")
                        .HasColumnType("integer")
                        .HasColumnName("folder_id");

                    b.Property<string>("PostingUrl")
                        .HasColumnType("text")
                        .HasColumnName("posting_url");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_jobs");

                    b.HasIndex("AuthorId")
                        .HasDatabaseName("ix_jobs_author_id");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_jobs_company_id");

                    b.HasIndex("FolderId")
                        .HasDatabaseName("ix_jobs_folder_id");

                    b.ToTable("jobs", (string)null);
                });

            modelBuilder.Entity("Celestia.Models.Company", b =>
                {
                    b.HasOne("Celestia.Models.Account", "Author")
                        .WithMany("Companies")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_companies_accounts_author_id");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Celestia.Models.Contact", b =>
                {
                    b.HasOne("Celestia.Models.Account", "Author")
                        .WithMany("Contacts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_contacts_accounts_author_id");

                    b.HasOne("Celestia.Models.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_contacts_companies_company_id");

                    b.Navigation("Author");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Celestia.Models.Folder", b =>
                {
                    b.HasOne("Celestia.Models.Account", "Author")
                        .WithMany("Folders")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_folders_accounts_author_id");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Celestia.Models.Job", b =>
                {
                    b.HasOne("Celestia.Models.Account", "Author")
                        .WithMany("Jobs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_jobs_accounts_author_id");

                    b.HasOne("Celestia.Models.Company", "Company")
                        .WithMany("Job")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_jobs_companies_company_id");

                    b.HasOne("Celestia.Models.Folder", "Folder")
                        .WithMany("Jobs")
                        .HasForeignKey("FolderId")
                        .HasConstraintName("fk_jobs_folders_folder_id");

                    b.Navigation("Author");

                    b.Navigation("Company");

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("Celestia.Models.Account", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Contacts");

                    b.Navigation("Folders");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("Celestia.Models.Company", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Celestia.Models.Folder", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
