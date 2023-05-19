﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace btlnhom09.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230518190321_Create_table_matudong")]
    partial class Createtablematudong
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("btlnhom09.Models.CongNhan", b =>
                {
                    b.Property<string>("MaCongNhan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Luong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhongBan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ViTri")
                        .HasColumnType("TEXT");

                    b.HasKey("MaCongNhan");

                    b.ToTable("CongNhan");
                });

            modelBuilder.Entity("btlnhom09.Models.HopDong", b =>
                {
                    b.Property<string>("HopDongID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeHopDong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HopDongID");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("btlnhom09.Models.Luong", b =>
                {
                    b.Property<string>("LuongID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoLuong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LuongID");

                    b.ToTable("Luong");
                });

            modelBuilder.Entity("btlnhom09.Models.Sale", b =>
                {
                    b.Property<string>("SaleID")
                        .HasColumnType("TEXT");

                    b.Property<string>("HopDongID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LuongID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleCCCD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalePhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ViTriSaleID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SaleID");

                    b.HasIndex("HopDongID");

                    b.HasIndex("LuongID");

                    b.HasIndex("ViTriSaleID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("btlnhom09.Models.SaleViTri", b =>
                {
                    b.Property<string>("ViTriSaleID")
                        .HasColumnType("TEXT");

                    b.Property<string>("VitriSale")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ViTriSaleID");

                    b.ToTable("SaleViTri");
                });

            modelBuilder.Entity("btlnhom09.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasColumnType("TEXT");

                    b.Property<string>("HopDongID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LuongID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffBank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffCCCD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffSex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ViTriStaffID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffID");

                    b.HasIndex("HopDongID");

                    b.HasIndex("LuongID");

                    b.HasIndex("ViTriStaffID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("btlnhom09.Models.StaffViTri", b =>
                {
                    b.Property<string>("ViTriStaffID")
                        .HasColumnType("TEXT");

                    b.Property<string>("VitriStaff")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ViTriStaffID");

                    b.ToTable("StaffViTri");
                });

            modelBuilder.Entity("btlnhom09.Models.Sale", b =>
                {
                    b.HasOne("btlnhom09.Models.HopDong", "HopDong")
                        .WithMany()
                        .HasForeignKey("HopDongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("btlnhom09.Models.Luong", "Luong")
                        .WithMany()
                        .HasForeignKey("LuongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("btlnhom09.Models.SaleViTri", "SaleViTri")
                        .WithMany()
                        .HasForeignKey("ViTriSaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HopDong");

                    b.Navigation("Luong");

                    b.Navigation("SaleViTri");
                });

            modelBuilder.Entity("btlnhom09.Models.Staff", b =>
                {
                    b.HasOne("btlnhom09.Models.HopDong", "HopDong")
                        .WithMany()
                        .HasForeignKey("HopDongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("btlnhom09.Models.Luong", "Luong")
                        .WithMany()
                        .HasForeignKey("LuongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("btlnhom09.Models.StaffViTri", "StaffViTri")
                        .WithMany()
                        .HasForeignKey("ViTriStaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HopDong");

                    b.Navigation("Luong");

                    b.Navigation("StaffViTri");
                });
#pragma warning restore 612, 618
        }
    }
}
