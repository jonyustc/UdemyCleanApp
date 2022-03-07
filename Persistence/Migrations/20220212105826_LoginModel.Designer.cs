﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220212105826_LoginModel")]
    partial class LoginModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Domain.BM_SecUser", b =>
                {
                    b.Property<decimal>("BM_UserID")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("AcceptERPAgreement")
                        .HasColumnType("int");

                    b.Property<int?>("AcceptPolicy")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BM_BranchID")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmailCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EmailDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailForward")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FailedAttempts")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FailedAttemptsTime")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Flag")
                        .HasColumnType("tinyint");

                    b.Property<int?>("HR_DeptID")
                        .HasColumnType("int");

                    b.Property<int?>("HR_DesgID")
                        .HasColumnType("int");

                    b.Property<decimal?>("HR_EmployeeID")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Inactive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("LoanAdvanceFinalized")
                        .HasColumnType("bit");

                    b.Property<bool?>("LoanAdvanceStart")
                        .HasColumnType("bit");

                    b.Property<string>("LogUserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MACAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PasswordVerified")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("PunchCardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Relegion_BM_ItemID")
                        .HasColumnType("int");

                    b.Property<int?>("Sex_BM_ItemID")
                        .HasColumnType("int");

                    b.Property<string>("SignaturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BM_UserID");

                    b.ToTable("BM_SecUser");
                });
#pragma warning restore 612, 618
        }
    }
}