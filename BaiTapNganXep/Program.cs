using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNganXep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen N:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so X can doi:");
            int x = int.Parse(Console.ReadLine());

            Stack s = new Stack();
            while (n > 0)
            {
                s.Push(n % x);
                n = n / x;
            }
            int value;
            Console.WriteLine($"Bieu dien he so {x}:");
            while (!s.isEmpty())
            {
                value = s.Pop();
                if (x == 16)
                {
                    switch (value)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        default:
                            Console.Write(value);
                            break;
                    }
                }
                else Console.Write(value);
                
            }
            Console.ReadLine();

        }
    }
}
