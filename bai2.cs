using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class bai2
    {
        int sl;
        string ma;

        public void nhap()
        {
            Console.WriteLine("Nhap sl = ");
            this.sl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap ma = ");
            this.ma =Console.ReadLine();
        }

        public int tinhtien()
        {
            int tien = 0;
            if (this.sl < 100)
            {
                tien = this.sl * 100000;
            }
            else {
                tien = this.sl * 80000;
            }
            return tien;
        }

        public void intien()
        {
            Console.WriteLine("Tau {0} co tong tien la {1}", this.ma, this.tinhtien());
            Console.ReadKey();
        }
    }
}
