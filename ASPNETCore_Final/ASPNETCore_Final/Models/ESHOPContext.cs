using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNETCore_Final.Models
{
    public partial class ESHOPContext : DbContext
    {
        public ESHOPContext()
        {
        }

        public ESHOPContext(DbContextOptions<ESHOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoiDap> HoiDap { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }

        // Unable to generate entity type for table 'dbo.YeuThich'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChiTietHD'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=THANHSANG\\SQLEXPRESS; Database=ESHOP;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.HasKey(e => e.MaHh);

                entity.Property(e => e.MaHh).HasColumnName("MaHH");

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.MaNcc)
                    .IsRequired()
                    .HasColumnName("MaNCC")
                    .HasMaxLength(50);

                entity.Property(e => e.TenHh)
                    .IsRequired()
                    .HasColumnName("TenHH")
                    .HasMaxLength(40);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MaLoai__145C0A3F");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MaNCC__15502E78");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.CachThanhToan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CachVanChuyen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasColumnName("MaKH")
                    .HasMaxLength(20);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.HasOne(d => d.MaTrangThaiNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaTrangThai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaTrangT__1ED998B2");
            });

            modelBuilder.Entity<HoiDap>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.CauHoi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50);

                entity.Property(e => e.NgayDua).HasColumnType("date");

                entity.Property(e => e.TraLoi).HasMaxLength(50);
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(60);

                entity.Property(e => e.DienThoai).HasMaxLength(24);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.TaiKhoan)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThaiHd).HasColumnName("TrangThaiHD");
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.Property(e => e.MaLoai).ValueGeneratedNever();

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenCongTy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.TrangThaiHd).HasColumnName("TrangThaiHD");

                entity.HasOne(d => d.MaPqNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.MaPq)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaPQ__1BFD2C07");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.MaPq);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");
            });

            modelBuilder.Entity<TrangThai>(entity =>
            {
                entity.HasKey(e => e.MaTrangThai);

                entity.Property(e => e.MaTrangThai).ValueGeneratedNever();

                entity.Property(e => e.TenTrangThai)
                    .IsRequired()
                    .HasMaxLength(30);
            });
        }
    }
}
