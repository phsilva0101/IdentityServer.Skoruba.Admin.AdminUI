﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using IdentityServer.Skoruba.Admin.Admin.EntityFramework.Shared.DbContexts;

namespace IdentityServer.Skoruba.Admin.Admin.EntityFramework.MySql.Migrations.AuditLogging
{
    [DbContext(typeof(AdminAuditLogDbContext))]
    [Migration("20191120085753_DbInit")]
    partial class DbInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Skoruba.AuditLogging.EntityFramework.Entities.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Data")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Event")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Source")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SubjectAdditionalData")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SubjectIdentifier")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SubjectName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SubjectType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("AuditLog");
                });
#pragma warning restore 612, 618
        }
    }
}








