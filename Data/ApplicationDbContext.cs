using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using btlnhom09.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<btlnhom09.Models.Sale> Sale { get; set; } = default!;

        public DbSet<btlnhom09.Models.Staff> Staff { get; set; } = default!;
        public DbSet<btlnhom09.Models.SaleViTri> SaleViTri { get; set; } = default!;

        public DbSet<btlnhom09.Models.StaffViTri> StaffViTri { get; set; } = default!;

        public DbSet<btlnhom09.Models.Luong> Luong { get; set; } = default!;

        public DbSet<btlnhom09.Models.HopDong> HopDong { get; set; } = default!;

        public DbSet<btlnhom09.Models.CongNhan> CongNhan { get; set; } = default!;

        public DbSet<btlnhom09.Models.Account> Account { get; set; } = default!;

        public DbSet<btlnhom09.Models.AccountViTri> AccountViTri { get; set; } = default!;

        public DbSet<btlnhom09.Models.CeoViTri> CeoViTri { get; set; } = default!;

        public DbSet<btlnhom09.Models.Ceo> Ceo { get; set; } = default!;
    }
