using System;

namespace GiaiBaiTap1
{
    class GiaiPhuongTrinhBac1
    {
        private double b, c;

        public GiaiPhuongTrinhBac1()
        {
            b = 0;
            c = 0;
        }

        public GiaiPhuongTrinhBac1(double b, double c)
        {
            this.b = b;
            this.c = c;
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public void Giai()
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("x =  {0}", x);
            }
        }
    }
    class GiaiPhuongTrinhBac2 : GiaiPhuongTrinhBac1
    {
        private double a;

        public GiaiPhuongTrinhBac2() : base()
        {
            a = 0;
        }

        public GiaiPhuongTrinhBac2(double a, double b, double c) : base(b, c)
        {
            this.a = a;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public void Giai()
        {
            if (a == 0)
            {
                base.Giai();
            }
            else
            {
                double delta = B * B - 4 * a * C;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong Trinh Vo Nghiem");
                }
                else if (delta == 0)
                {
                    double x1 = -B / (2 * a);
                    Console.WriteLine("Phuong Trinh Co Nghiem Kep X1 = X2 = {0} ", x1);
                }
                else
                {
                    double x1 = ((-B + Math.Sqrt(delta)) / (2 * a));
                    double x2 = ((-B - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("Phuong Trinh Co 2 Nghiem Phan Biet : X1 = {0} , X2 = {1} ", x1, x2);
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("********************-Giai Phuong Trinh Bac 2-********************");

            double a;
            Console.Write("Nhap A : ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Nhap Lai A : ");
            }

            double b;
            Console.Write("Nhap B : ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Nhap Lai B : ");
            }

            double c;
            Console.Write("Nhap C : ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Nhap Lai C : ");
            }



            GiaiPhuongTrinhBac2 GPTB2 = new GiaiPhuongTrinhBac2(a, b, c);
            GPTB2.Giai();
        }
    }
}