using System;

namespace vidu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = Convert.ToInt16(Console.ReadLine());

            sinhvien[] arrsv = new sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu: " + (i + 1).ToString());
                arrsv[i] = new sinhvien();
                arrsv[i].Nhap();

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arrsv[j].TinhTB() < arrsv[i].TinhTB())
                    {
                        sinhvien sx;
                        sx = arrsv[i];
                        arrsv[i] = arrsv[j];
                        arrsv[j] = sx;
                    }
                }
            }
            float min = arrsv[0].TinhTB();
            for(int i = 1; i<n; i++)
            {
                if(arrsv[i].TinhTB() < min)
                {
                    min = arrsv[i].TinhTB();
                }
            }
            Console.Write("Sinh vien co diem trung binh thap nhat la: " +min);

            for(int i = 0; i<n; i++)
            {
                if (arrsv[i].masv.Contains("IT"))
                    Console.WriteLine("Sinh vien ma {0} co diem tb la {1}", arrsv[i].masv.Contains("IT");
            }

            Console.WriteLine("\nDanh sach sinh vien:");
            Console.WriteLine("{0,-15}{1,-15}", "masv", "diemtb");

            for (int i = 0; i < n; i++)
            {
                arrsv[i].Hienthi();
            }
            Console.ReadLine();

            




        }
    }
}
