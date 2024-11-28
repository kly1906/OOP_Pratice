using System.Text;

namespace BTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Bai 1
            // Khoi tao doi tuong moi
            DiemDanh ngayDiemDanh = new DiemDanh(DateTime.Now);

            // Them hoc sinh vao danh sach
            ngayDiemDanh.themHocSinh("Nguyen Van A");
            ngayDiemDanh.themHocSinh("Tran Thi B");
            ngayDiemDanh.themHocSinh("Le Van C");

            // Hien thi danh sach
            ngayDiemDanh.hienThiDanhSach();

            // kiem tra hoc sing vang mat
            var danhSachVangMat = new List<string> { "Nguyen Van A", "Tran Thi D" };
            ngayDiemDanh.kiemTraVangMat(danhSachVangMat);

            Console.ReadKey();
            Console.Clear();

            //Bai 2
            // tao doi tuong sinh vien moi
            SinhVien sv1 = new SinhVien("Nguyen Van A", "SV001", 8.5, 7.5);

            // hien thi thong tin sinh vien
            sv1.hienThiThongTin();

            // tao doi tuong sinh vien moi
            SinhVien sv2 = new SinhVien("Tran Thi B", "SV002", 9.0, 8.0);

            // hien thi thong tin sinh vien
            sv2.hienThiThongTin();

            Console.ReadKey();
            Console.Clear();

            //Bai 3
            // khoi tao doi tuong nhan vien moi
            NhanVien nv1 = new NhanVien("Nguyen Van A", "NV001", 260000, 22);

            // hien thi thong tin nhan vien
            nv1.hienThiThongTin();

            // khoi tao doi tuong nhan vien moi
            NhanVien nv2 = new NhanVien("Tran Thi B", "NV002", 210000, 20);

            // hien thi thong tin nhan vien
            nv2.hienThiThongTin();

            Console.ReadKey();
            Console.Clear();

            //Bai4
            // khoi tao san pham moi
            SanPham sp1 = new SanPham("Điện thoại", "SP001", 15000000, 3);

            // hien thi thong tin san pham
            sp1.hienThiThongTin();

            // khoi tao san pham moi
            SanPham sp2 = new SanPham("Laptop", "SP002", 22000000, 10);

            // hien thi thong tin san pham
            sp2.hienThiThongTin();

            Console.ReadKey();
            Console.Clear() ;

            //Bai 5
            // khoi tao hoc phan moi
            HocPhan hp1 = new HocPhan("Lập trình C#", "HP001", 3, 8.5);

            // hien thi thong tin hoc phan
            hp1.hienThiThongTin();

            // khoi tao hoc phan moi
            HocPhan hp2 = new HocPhan("Cơ sở dữ liệu", "HP002", 4, 3.0);

            // hien thi thong tin hoc phan
            hp2.hienThiThongTin();

            Console.ReadKey();
        }
    }
}