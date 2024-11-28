using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class NhanVien
    {
        // cac thuoc tinh
        public string hoTen;
        public string maNV;
        public double luongCoBan;
        public int soNgayCong;

        // phuong thuc khoi tao
        public NhanVien(string hoten, string manv, double luongcb, int songay)
        {
            hoTen = hoten;
            maNV = manv;
            luongCoBan = luongcb;
            soNgayCong = songay;
        }

        // phuong thuc tinh tong luong
        public double tinhLuong()
        {
            return luongCoBan * soNgayCong;
        }

        // phuong thuc hien thi thong tin
        public void hienThiThongTin()
        {
            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine($"Họ và tên: {hoTen}");
            Console.WriteLine($"Mã nhân viên: {maNV}");
            Console.WriteLine($"Lương cơ bản: {luongCoBan}");
            Console.WriteLine($"Số ngày công: {soNgayCong}");
            Console.WriteLine($"Tổng lương: {tinhLuong()}");
        }
    }

}
