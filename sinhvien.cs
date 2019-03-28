using System;
using System.Collections.Generic;
using System.Text;

namespace vidu
{
    class sinhvien
    {
        public String masv;
        float toan;
        float ly;
        float hoa;

        public sinhvien()
        {
            this.masv = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        public sinhvien(String masv, float toan, float ly, float hoa)
        {
            this.masv = masv;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien:");
            masv = Console.ReadLine();
            Console.WriteLine("Nhap diem toan:");
            toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly:");
            ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa:");
            hoa = float.Parse(Console.ReadLine());

        }
        public float TinhTB()
        {
            float diemtb = (this.toan + this.ly + this.hoa) / 3;
            return diemtb;
        }
        
        public void Hienthi()
        {
            Console.WriteLine("{0,-15}{1,-15}", masv,TinhTB());
        }
    }
}
