using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baitap
{
    class bai1
    {
        
        int n;
        public void Nhap()
        {
            Console.WriteLine("Nhap n = ");
            this.n =Convert.ToInt32( Console.ReadLine());
        }

        public int tonga()
        {
            int s = 0;
            for (int i = 1; i <= this.n; i+=2)
            {
                
            }
            return s;
        }
        public float tongb()
        {
            int s = 0;
            for (int i = 1; i <= n; i++) {
                if (i < n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else
                {
                    Console.Write("1/{0}", i);
                }
                s += 1 / (float)i;
            }
            return s;
        }

        
        public void intong()
        {
            Console.WriteLine("tong {0}", this.tonga());
            Console.WriteLine("tong {0}", this.tongb());
            Console.ReadKey();
        }
        
    }
}
