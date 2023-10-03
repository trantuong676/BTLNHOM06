﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTL06.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("BTL06.Models.KhachHang", b =>
                {
                    b.Property<string>("KhachHangCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KhachHangName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangCode");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BTL06.Models.Kho", b =>
                {
                    b.Property<string>("KhoID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExportKho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KhoStoreExists")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberKho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SanPhamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KhoID");

                    b.HasIndex("SanPhamName");

                    b.ToTable("Kho");
                });

            modelBuilder.Entity("BTL06.Models.NhanVien", b =>
                {
                    b.Property<string>("NhanVienCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NhanVienName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NhanVienCode");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BTL06.Models.SanPham", b =>
                {
                    b.Property<string>("SanPhamID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SanPhamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SanPhamID");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("BTL06.Models.Kho", b =>
                {
                    b.HasOne("BTL06.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });
#pragma warning restore 612, 618
        }
    }
}