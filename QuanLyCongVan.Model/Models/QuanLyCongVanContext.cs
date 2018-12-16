using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyCongVan.Model.Models
{
    public partial class QuanLyCongVanContext : DbContext
    {
        public QuanLyCongVanContext()
        {
        }

        public QuanLyCongVanContext(DbContextOptions<QuanLyCongVanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CapCqbh> CapCqbh { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<Cqbh> Cqbh { get; set; }
        public virtual DbSet<DoKhan> DoKhan { get; set; }
        public virtual DbSet<DoMat> DoMat { get; set; }
        public virtual DbSet<FileVb> FileVb { get; set; }
        public virtual DbSet<LoaiVanBan> LoaiVanBan { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhanSu> NhanSu { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }
        public virtual DbSet<VanBan> VanBan { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Bon;Database=QuanLyCongVan;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapCqbh>(entity =>
            {
                entity.ToTable("CapCQBH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.MaCapCqbh)
                    .IsRequired()
                    .HasColumnName("MaCapCQBH")
                    .HasMaxLength(50);

                entity.Property(e => e.TenCapCqbh)
                    .IsRequired()
                    .HasColumnName("TenCapCQBH")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaChucVu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenChucVu)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Cqbh>(entity =>
            {
                entity.ToTable("CQBH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.MaCapCqbh)
                    .HasColumnName("MaCapCQBH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaCqbh)
                    .IsRequired()
                    .HasColumnName("MaCQBH")
                    .HasMaxLength(50);

                entity.Property(e => e.TenCqbh)
                    .IsRequired()
                    .HasColumnName("TenCQBH")
                    .HasMaxLength(200);

                entity.Property(e => e.TenVietTat).HasMaxLength(20);
            });

            modelBuilder.Entity<DoKhan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TenDoKhan)
                    .IsRequired()
                    .HasColumnName("TenDoKhan")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(200);
            });

            modelBuilder.Entity<DoMat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TenDoMat)
                    .IsRequired()
                    .HasColumnName("TenDoMat")
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(200);
            });

            modelBuilder.Entity<FileVb>(entity =>
            {
                entity.ToTable("FileVB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TenFileVb)
                    .IsRequired()
                    .HasColumnName("TenFileVB")
                    .HasMaxLength(50);

                entity.Property(e => e.VanBanId).HasColumnName("VanBanID");

                entity.HasOne(d => d.VanBan)
                    .WithMany(p => p.FileVb)
                    .HasForeignKey(d => d.VanBanId)
                    .HasConstraintName("FK__FileVB__VanBanID__2E1BDC42");
            });

            modelBuilder.Entity<LoaiVanBan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaLoaiVb)
                    .HasColumnName("MaLoaiVB")
                    .HasMaxLength(50);

                entity.Property(e => e.TenLoaiVb)
                    .HasColumnName("TenLoaiVB")
                    .HasMaxLength(100);

                entity.Property(e => e.TenVietTat).HasMaxLength(20);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaNhanSu).HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TenTaiKhoan)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NhanSu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Anh).HasMaxLength(50);

                entity.Property(e => e.Dem)
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChiCq)
                    .HasColumnName("DiaChiCQ")
                    .HasMaxLength(200);

                entity.Property(e => e.DiaChiNr)
                    .HasColumnName("DiaChiNR")
                    .HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(20);

                entity.Property(e => e.Ho)
                    .HasMaxLength(50);

                entity.Property(e => e.MaNhanSu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaPhong).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.NgayVaoNganh).HasColumnType("datetime");

                entity.Property(e => e.Ten)
                    .HasMaxLength(10);

                entity.Property(e => e.TenVietTat)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DienThoai).HasMaxLength(20);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.MaNhanSu).HasMaxLength(50);

                entity.Property(e => e.MaPhong)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VanBan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoKhan).HasMaxLength(50);

                entity.Property(e => e.DoMat).HasMaxLength(50);

                entity.Property(e => e.HanXuLy).HasColumnType("datetime");

                entity.Property(e => e.MaCqbh)
                    .HasColumnName("MaCQBH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaLoaiVb)
                    .HasColumnName("MaLoaiVB")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayDen).HasColumnType("datetime");

                entity.Property(e => e.NgayKy).HasColumnType("datetime");

                entity.Property(e => e.NguoiKy).HasMaxLength(50);

                entity.Property(e => e.NoiNhan).HasMaxLength(200);

                entity.Property(e => e.SoDen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoVb)
                    .IsRequired()
                    .HasColumnName("SoVB")
                    .HasMaxLength(50);

                entity.Property(e => e.TrichYeu).HasMaxLength(1000);

                entity.Property(e => e.VbdiDen).HasColumnName("VBDiDen");
            });
        }
    }
}
