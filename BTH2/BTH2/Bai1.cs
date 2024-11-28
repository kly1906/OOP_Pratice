using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2
{
    class DiemDanh
    {
        // Cac thuoc tinh
        public DateTime ngayDiemDanh;
        public List<string> danhSachHocSinh;

        // phuong thuc khoi tao
        public DiemDanh(DateTime ngay)
        {
            ngayDiemDanh = ngay;
            danhSachHocSinh = new List<string>();
        }

        // phuong thuc kiem tra vang mat
        public List<string> kiemTraVangMat(List<string> danhSachVangMat)
        {
            List<string> hocSinhVangMat = new List<string>();
            foreach (var hsVang in danhSachVangMat)
            {
                if (!danhSachHocSinh.Contains(hsVang))
                {
                    hocSinhVangMat.Add(hsVang);
                }
            }
            return hocSinhVangMat;
        }

        public void themHocSinh(string hocSinh)
        {
            if (!danhSachHocSinh.Contains(hocSinh))
            {
                danhSachHocSinh.Add(hocSinh);
                Console.WriteLine($"Đã thêm học sinh: {hocSinh}");
            }
            else
            {
                Console.WriteLine($"Học sinh {hocSinh} đã có trong danh sách.");
            }
        }

        public void hienThiDanhSach()
        {
            Console.WriteLine($"Danh sách học sinh tham gia (ngày {ngayDiemDanh.ToShortDateString()}):");
            if (danhSachHocSinh.Count > 0)
            {
                foreach (var hs in danhSachHocSinh)
                {
                    Console.WriteLine(hs);
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào tham gia.");
            }
        }

    }
}
