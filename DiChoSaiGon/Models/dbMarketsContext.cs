using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class dbMarketsContext : DbContext
    {
        public dbMarketsContext()
        {
        }

        public dbMarketsContext(DbContextOptions<dbMarketsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<TAnhChiTietSp> TAnhChiTietSps { get; set; }
        public virtual DbSet<TAnhSp> TAnhSps { get; set; }
        public virtual DbSet<TChatLieu> TChatLieus { get; set; }
        public virtual DbSet<TChiTietHdb> TChiTietHdbs { get; set; }
        public virtual DbSet<TChiTietSanPham> TChiTietSanPhams { get; set; }
        public virtual DbSet<TDanhMucSp> TDanhMucSps { get; set; }
        public virtual DbSet<THangSx> THangSxes { get; set; }
        public virtual DbSet<THoaDonBan> THoaDonBans { get; set; }
        public virtual DbSet<TKhachHang> TKhachHangs { get; set; }
        public virtual DbSet<TKichThuoc> TKichThuocs { get; set; }
        public virtual DbSet<TLoaiDt> TLoaiDts { get; set; }
        public virtual DbSet<TLoaiSp> TLoaiSps { get; set; }
        public virtual DbSet<TMauSac> TMauSacs { get; set; }
        public virtual DbSet<TNhanVien> TNhanViens { get; set; }
        public virtual DbSet<TQuocGium> TQuocGia { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TblTinTuc> TblTinTucs { get; set; }
        public virtual DbSet<TransactStatus> TransactStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=THAITHANHDAT\\MASTERMOS;Initial Catalog=dbMarkets;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("AccountID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Salt)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Accounts_Roles");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Alias).HasMaxLength(250);

                entity.Property(e => e.CatName).HasMaxLength(250);

                entity.Property(e => e.Cover).HasMaxLength(250);

                entity.Property(e => e.MetaDesc).HasMaxLength(250);

                entity.Property(e => e.MetaKey).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Thumb).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Avatar).HasMaxLength(255);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(8)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameWithType).HasMaxLength(255);

                entity.Property(e => e.PathWithType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Slug).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CusromerId).HasColumnName("CusromerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.TransactStatusId).HasColumnName("TransactStatusID");

                entity.HasOne(d => d.Cusromer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CusromerId)
                    .HasConstraintName("FK_Orders_Customers");

                entity.HasOne(d => d.TransactStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TransactStatusId)
                    .HasConstraintName("FK_Orders_TransactStatus");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OderdetailId);

                entity.Property(e => e.OderdetailId).HasColumnName("OderdetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetails_Orders");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Alias).HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.MetaDesc).HasMaxLength(250);

                entity.Property(e => e.MetaKey).HasMaxLength(250);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.Thumb).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Alias).HasMaxLength(255);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.MetaDesc).HasMaxLength(255);

                entity.Property(e => e.MetaKey).HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ShortDesc).HasMaxLength(255);

                entity.Property(e => e.Thumb).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Video).HasMaxLength(255);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_Products_Categories");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.Company).HasMaxLength(150);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperName).HasMaxLength(150);
            });

            modelBuilder.Entity<TAnhChiTietSp>(entity =>
            {
                entity.HasKey(e => new { e.MaChiTietSp, e.TenFileAnh });

                entity.ToTable("tAnhChiTietSP");

                entity.Property(e => e.MaChiTietSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaChiTietSP")
                    .IsFixedLength(true);

                entity.Property(e => e.TenFileAnh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaChiTietSpNavigation)
                    .WithMany(p => p.TAnhChiTietSps)
                    .HasForeignKey(d => d.MaChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAnhChiTietSP_tChiTietSanPham");
            });

            modelBuilder.Entity<TAnhSp>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.TenFileAnh });

                entity.ToTable("tAnhSP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.TenFileAnh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.TAnhSps)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAnhSP_tDanhMucSP");
            });

            modelBuilder.Entity<TChatLieu>(entity =>
            {
                entity.HasKey(e => e.MaChatLieu);

                entity.ToTable("tChatLieu");

                entity.Property(e => e.MaChatLieu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChatLieu).HasMaxLength(150);
            });

            modelBuilder.Entity<TChiTietHdb>(entity =>
            {
                entity.HasKey(e => new { e.MaHoaDon, e.MaChiTietSp });

                entity.ToTable("tChiTietHDB");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaChiTietSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaChiTietSP")
                    .IsFixedLength(true);

                entity.Property(e => e.DonGiaBan).HasColumnType("money");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.HasOne(d => d.MaChiTietSpNavigation)
                    .WithMany(p => p.TChiTietHdbs)
                    .HasForeignKey(d => d.MaChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietHDB_tChiTietSanPham");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.TChiTietHdbs)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietHDB_tHoaDonBan");
            });

            modelBuilder.Entity<TChiTietSanPham>(entity =>
            {
                entity.HasKey(e => e.MaChiTietSp);

                entity.ToTable("tChiTietSanPham");

                entity.Property(e => e.MaChiTietSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaChiTietSP")
                    .IsFixedLength(true);

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKichThuoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.Slton).HasColumnName("SLTon");

                entity.Property(e => e.Video)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaKichThuocNavigation)
                    .WithMany(p => p.TChiTietSanPhams)
                    .HasForeignKey(d => d.MaKichThuoc)
                    .HasConstraintName("FK_tChiTietSanPham_tKichThuoc");

                entity.HasOne(d => d.MaMauSacNavigation)
                    .WithMany(p => p.TChiTietSanPhams)
                    .HasForeignKey(d => d.MaMauSac)
                    .HasConstraintName("FK_tChiTietSanPham_tMauSac");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.TChiTietSanPhams)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_tChiTietSanPham_tDanhMucSP");
            });

            modelBuilder.Entity<TDanhMucSp>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("tDanhMucSP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GiaLonNhat).HasColumnType("money");

                entity.Property(e => e.GiaNhoNhat).HasColumnType("money");

                entity.Property(e => e.GioiThieuSp)
                    .HasMaxLength(255)
                    .HasColumnName("GioiThieuSP");

                entity.Property(e => e.MaChatLieu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaDacTinh)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaDt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaDT")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHangSx)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaHangSX")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaNuocSx)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaNuocSX")
                    .IsFixedLength(true);

                entity.Property(e => e.Model).HasMaxLength(55);

                entity.Property(e => e.NganLapTop).HasMaxLength(55);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(150)
                    .HasColumnName("TenSP");

                entity.Property(e => e.Website)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaChatLieuNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaChatLieu)
                    .HasConstraintName("FK_tDanhMucSP_tChatLieu");

                entity.HasOne(d => d.MaDtNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaDt)
                    .HasConstraintName("FK_tDanhMucSP_tLoaiDT");

                entity.HasOne(d => d.MaHangSxNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaHangSx)
                    .HasConstraintName("FK_tDanhMucSP_tHangSX");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_tDanhMucSP_tLoaiSP");

                entity.HasOne(d => d.MaNuocSxNavigation)
                    .WithMany(p => p.TDanhMucSps)
                    .HasForeignKey(d => d.MaNuocSx)
                    .HasConstraintName("FK_tDanhMucSP_tQuocGia");
            });

            modelBuilder.Entity<THangSx>(entity =>
            {
                entity.HasKey(e => e.MaHangSx);

                entity.ToTable("tHangSX");

                entity.Property(e => e.MaHangSx)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaHangSX")
                    .IsFixedLength(true);

                entity.Property(e => e.HangSx)
                    .HasMaxLength(100)
                    .HasColumnName("HangSX");

                entity.Property(e => e.MaNuocThuongHieu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<THoaDonBan>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon);

                entity.ToTable("tHoaDonBan");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.GiamGiaHd).HasColumnName("GiamGiaHD");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NgayHoaDon).HasColumnType("datetime");

                entity.Property(e => e.ThongTinThue).HasMaxLength(250);

                entity.Property(e => e.TongTienHd)
                    .HasColumnType("money")
                    .HasColumnName("TongTienHD");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.THoaDonBans)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK_tHoaDonBan_tKhachHang");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.THoaDonBans)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK_tHoaDonBan_tNhanVien");
            });

            modelBuilder.Entity<TKhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhanhHang);

                entity.ToTable("tKhachHang");

                entity.Property(e => e.MaKhanhHang)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TKhachHangs)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK_tKhachHang_tUser");
            });

            modelBuilder.Entity<TKichThuoc>(entity =>
            {
                entity.HasKey(e => e.MaKichThuoc);

                entity.ToTable("tKichThuoc");

                entity.Property(e => e.MaKichThuoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.KichThuoc)
                    .HasMaxLength(150)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TLoaiDt>(entity =>
            {
                entity.HasKey(e => e.MaDt);

                entity.ToTable("tLoaiDT");

                entity.Property(e => e.MaDt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MaDT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<TLoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("tLoaiSP");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Loai).HasMaxLength(100);
            });

            modelBuilder.Entity<TMauSac>(entity =>
            {
                entity.HasKey(e => e.MaMauSac);

                entity.ToTable("tMauSac");

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenMauSac).HasMaxLength(100);
            });

            modelBuilder.Entity<TNhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien);

                entity.ToTable("tNhanVien");

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChucVu).HasMaxLength(100);

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SoDienThoai2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TNhanViens)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK_tNhanVien_tUser");
            });

            modelBuilder.Entity<TQuocGium>(entity =>
            {
                entity.HasKey(e => e.MaNuoc);

                entity.ToTable("tQuocGia");

                entity.Property(e => e.MaNuoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenNuoc).HasMaxLength(100);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tUser");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblTinTuc>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.ToTable("tblTinTucs");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Alias).HasMaxLength(255);

                entity.Property(e => e.Author).HasMaxLength(255);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsHot).HasColumnName("isHot");

                entity.Property(e => e.IsNewfeed).HasColumnName("isNewfeed");

                entity.Property(e => e.MetaDesc).HasMaxLength(255);

                entity.Property(e => e.MetaKey).HasMaxLength(255);

                entity.Property(e => e.Scontents)
                    .HasMaxLength(255)
                    .HasColumnName("SContents");

                entity.Property(e => e.Thumb).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<TransactStatus>(entity =>
            {
                entity.ToTable("TransactStatus");

                entity.Property(e => e.TransactStatusId).HasColumnName("TransactStatusID");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
