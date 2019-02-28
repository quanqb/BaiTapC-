using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            bai1 n = new bai1();
            n.Nhap();
            n.tonga();
            n.tongb();
            n.intong();

            bai2 m = new bai2();
            m.nhap();
            m.tinhtien();
            m.intien();

        }
    }
}
