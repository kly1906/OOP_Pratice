using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class SinhVien
    {
        // cac  thuoc tinh 
        public string hoTen;
        public string maSV;
        public double diemToan;
        public double diemVan;

        // phuong thuc khoi tao
        public SinhVien(string hoten, string masv, double diemtoan, double diemvan)
        {
            hoTen = hoten;
            maSV = masv;
            diemToan = diemtoan;
            diemVan = diemvan;
        }

        // phuong thuc tinh diem trung binh cong
        public double tinhDiemTrungBinh()
        {
            return (diemToan + diemVan) / 2;
        }

        // phuong thuc hien thi thong tin sinh vien
        public void hienThiThongTin()
        {
            Console.WriteLine("Thông tin sinh viên:");
            Console.WriteLine($"Họ và tên: {hoTen}");
            Console.WriteLine($"Mã sinh viên: {maSV}");
            Console.WriteLine($"Điểm Toán: {diemToan}");
            Console.WriteLine($"Điểm Văn: {diemVan}");
            Console.WriteLine($"Điểm trung bình: {tinhDiemTrungBinh():F2}"); //lam tron den chu so thap phan thu 2 
        }
    }
}
