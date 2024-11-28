using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class SanPham
    {
        // cac thuoc tinh
        public string maSP;
        public string tenSP;
        public double giaBan;
        public int soLuongTon;

        // ham khoi tao
        public SanPham(string masp, string tensp, double giaban, int soluongton)
        {
            maSP = masp;
            tenSP = tensp;
            giaBan = giaban;
            soLuongTon = soluongton;
        }

        // Method to calculate total price
        public bool kiemTraDatHang()
        {
            return soLuongTon < 5;
        }

        // Method to display product information    
        public void hienThiThongTin()
        {
            Console.WriteLine("Thông tin sản phẩm:");
            Console.WriteLine($"Tên sản phẩm: {tenSP}");
            Console.WriteLine($"Mã sản phẩm: {maSP}");
            Console.WriteLine($"Giá bán: {giaBan}");
            Console.WriteLine($"Số lượng tồn kho: {soLuongTon}");
            Console.WriteLine($"Cần đặt hàng thêm: {(kiemTraDatHang() ? "Có" : "Không")}");
        }
    }
}
