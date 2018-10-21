namespace DataAccess.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyCongVan : DbContext
    {
        public QuanLyCongVan()
            : base("name=QuanLyCongVan")
        {
        }

        public virtual DbSet<CapSo> CapSo { get; set; }
        public virtual DbSet<CCQBH> CCQBH { get; set; }
        public virtual DbSet<CQBH> CQBH { get; set; }
        public virtual DbSet<CV_Den> CV_Den { get; set; }
        public virtual DbSet<CV_Di> CV_Di { get; set; }
        public virtual DbSet<DoKhan> DoKhan { get; set; }
        public virtual DbSet<DoMat> DoMat { get; set; }
        public virtual DbSet<DV> DV { get; set; }
        public virtual DbSet<KhoLuuTru> KhoLuuTru { get; set; }
        public virtual DbSet<LoaiBQ> LoaiBQ { get; set; }
        public virtual DbSet<LuuTru> LuuTru { get; set; }
        public virtual DbSet<LVB> LVB { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<NBH> NBH { get; set; }
        public virtual DbSet<NND> NND { get; set; }
        public virtual DbSet<NNVB> NNVB { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<SVB> SVB { get; set; }
        public virtual DbSet<TDK> TDK { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapSo>()
                .HasMany(e => e.LuuTru)
                .WithOptional(e => e.CapSo1)
                .HasForeignKey(e => e.CapSo);

            modelBuilder.Entity<CCQBH>()
                .HasMany(e => e.CQBH)
                .WithOptional(e => e.CCQBH)
                .HasForeignKey(e => e.IdCCQBH);

            modelBuilder.Entity<CQBH>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CQBH>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<CQBH>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<CQBH>()
                .Property(e => e.TenTat)
                .IsUnicode(false);

            modelBuilder.Entity<CV_Den>()
                .HasMany(e => e.CV_Den1)
                .WithOptional(e => e.CV_Den2)
                .HasForeignKey(e => e.TLcVB);

            modelBuilder.Entity<CV_Den>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.CV_Den)
                .HasForeignKey(e => e.TLcVB);

            modelBuilder.Entity<DoKhan>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.DoKhan1)
                .HasForeignKey(e => e.DoKhan);

            modelBuilder.Entity<DoKhan>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.DoKhan1)
                .HasForeignKey(e => e.DoKhan);

            modelBuilder.Entity<DoMat>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.DoMat1)
                .HasForeignKey(e => e.DoMat);

            modelBuilder.Entity<DoMat>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.DoMat1)
                .HasForeignKey(e => e.DoMat);

            modelBuilder.Entity<DV>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.DV)
                .HasForeignKey(e => e.DVKy);

            modelBuilder.Entity<DV>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.DV)
                .HasForeignKey(e => e.DV_Soanthao);

            modelBuilder.Entity<DV>()
                .HasMany(e => e.CV_Di1)
                .WithOptional(e => e.DV1)
                .HasForeignKey(e => e.DVKy);

            modelBuilder.Entity<DV>()
                .HasMany(e => e.NND)
                .WithOptional(e => e.DV)
                .HasForeignKey(e => e.MaDV);

            modelBuilder.Entity<KhoLuuTru>()
                .HasMany(e => e.LuuTru)
                .WithOptional(e => e.KhoLuuTru)
                .HasForeignKey(e => e.KhoLT);

            modelBuilder.Entity<LoaiBQ>()
                .HasMany(e => e.LuuTru)
                .WithOptional(e => e.LoaiBQ1)
                .HasForeignKey(e => e.LoaiBQ);

            modelBuilder.Entity<NNVB>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NNVB>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NNVB>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.LuuTru)
                .WithOptional(e => e.Phong1)
                .HasForeignKey(e => e.Phong);

            modelBuilder.Entity<SVB>()
                .Property(e => e.SoVB)
                .IsUnicode(false);

            modelBuilder.Entity<SVB>()
                .Property(e => e.KyHieu)
                .IsUnicode(false);

            modelBuilder.Entity<SVB>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.SVB1)
                .HasForeignKey(e => e.SoVB);

            modelBuilder.Entity<SVB>()
                .HasMany(e => e.CV_Den1)
                .WithOptional(e => e.SVB2)
                .HasForeignKey(e => e.SVB);

            modelBuilder.Entity<SVB>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.SVB)
                .HasForeignKey(e => e.SoVB);

            modelBuilder.Entity<TDK>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.TDK)
                .HasForeignKey(e => e.DinhKem);

            modelBuilder.Entity<TDK>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.TDK)
                .HasForeignKey(e => e.DinhKem);

            modelBuilder.Entity<Users>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Passwords)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Den)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.NKy);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Den1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.NPT);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Den2)
                .WithOptional(e => e.Users2)
                .HasForeignKey(e => e.NST);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Di)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.NKy);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Di1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.NPT);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CV_Di2)
                .WithOptional(e => e.Users2)
                .HasForeignKey(e => e.NST);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.NND)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.TDK)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.NgUpload);
        }
    }
}
