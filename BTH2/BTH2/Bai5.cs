using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class HocPhan
    {
        // cac thuoc tinh
        public string tenHP;
        public string maHP;
        public int soTinChi;
        public double diemThi;

        // phuong thuc khoi tao
        public HocPhan(string tenhp, string mahp, int sotc, double diemthi)
        {
            tenHP = tenhp;
            maHP = mahp;
            soTinChi = sotc;
            diemThi = diemthi;
        }

        // phương thức kiểm tra qua môn 
        public bool kiemTraQuaMon()
        {
            return diemThi >= 5.0;
        }

        // phương thức hiển thị thông tin học phần 
        public void hienThiThongTin()
        {
            Console.WriteLine("Thông tin học phần:");
            Console.WriteLine($"Tên học phần: {tenHP}");
            Console.WriteLine($"Mã học phần: {maHP}");
            Console.WriteLine($"Số tín chỉ: {soTinChi}");
            Console.WriteLine($"Điểm thi: {diemThi:F2}");
            Console.WriteLine($"Trạng thái qua môn: {(kiemTraQuaMon() ? "Đã qua môn" : "Chưa qua môn")}");
        }
    }
}
