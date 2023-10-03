using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTL06.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BTL06.Models.KhachHang> KhachHang { get; set; } = default!;

        public DbSet<BTL06.Models.SanPham> SanPham { get; set; } = default!;

        public DbSet<BTL06.Models.NhanVien> NhanVien { get; set; } = default!;

        public DbSet<BTL06.Models.Kho> Kho { get; set; } = default!;
    }
