using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение коэффициента k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Solution solution = new Solution { K = k, B = b };
            solution.Root(out double x);
            Console.WriteLine("Решение линейного уравнения \"0=kx+b\": x={0}.",x);
            Console.ReadKey();
        }
    }
    struct Solution
    {
        double k;
        public double B { get; set; }
        public double K
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Ошибка! Коэффициент k не должен быть равен нулю. Коэффициенту присвоено значение по умолчанию k=1.");
                    k = 1;
                }
                else
                {
                    k = value;
                }
            }
            get
            {
                return k;
            }
        }
        public void Root(out double x)
        {
            x = -B / k;
        }
    }
}
