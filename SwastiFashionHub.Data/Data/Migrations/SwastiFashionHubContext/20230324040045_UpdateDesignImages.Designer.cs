﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwastiFashionHub.Data.Context;

#nullable disable

namespace SwastiFashionHub.Data.Data.Migrations.SwastiFashionHubContext
{
    [DbContext(typeof(SwastiFashionHubLlpContext))]
    [Migration("20230324040045_UpdateDesignImages")]
    partial class UpdateDesignImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SwastiFashionHub.Data.Models.Design", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.Fabric", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Fabrics");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.FabricChallan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ChallanDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChallanImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChallanNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FabricId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FabricType")
                        .HasColumnType("int");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<Guid>("PartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TakaDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FabricChallans");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.JobChallan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ChallanDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ChallanImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChallanNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesignNo")
                        .HasColumnType("int");

                    b.Property<Guid>("FabricId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<Guid>("PartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalFabric")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("JobChallans");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.JobChallanTakaDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("FabricChallanId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("JobChallanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TakaDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobChallanId");

                    b.ToTable("JobChallanTakaDetails");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.OrderForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryInDays")
                        .HasColumnType("int");

                    b.Property<int>("DesignNo")
                        .HasColumnType("int");

                    b.Property<int>("FabricType")
                        .HasColumnType("int");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("JobNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("TotalMtr")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Unit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrderForms");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.OrderFormDesignDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ColorQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderFormId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderFormId");

                    b.ToTable("OrderFormDesignDetails");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.Party", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartyType")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.JobChallanTakaDetail", b =>
                {
                    b.HasOne("SwastiFashionHub.Data.Models.JobChallan", "JobChallan")
                        .WithMany("JobChallanTakaDetails")
                        .HasForeignKey("JobChallanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobChallan");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.OrderFormDesignDetail", b =>
                {
                    b.HasOne("SwastiFashionHub.Data.Models.OrderForm", "OrderForm")
                        .WithMany("OrderFormDesignDetails")
                        .HasForeignKey("OrderFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderForm");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.JobChallan", b =>
                {
                    b.Navigation("JobChallanTakaDetails");
                });

            modelBuilder.Entity("SwastiFashionHub.Data.Models.OrderForm", b =>
                {
                    b.Navigation("OrderFormDesignDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
