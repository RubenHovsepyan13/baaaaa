using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myC_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int g = Convert.ToInt32(Console.ReadLine());
            //int[] a = { 2, 5, 9, 11, 4 };
            //int[] c = { 3, 13, 6, 4, 1, };
            string[] x = { "Ruben", "Edgar", "Anna", "Erik" };
            string[] s = { "gago", "Mher", "Haykuhi", "Noa" };
            //char ch = Convert.ToChar(Console.ReadLine());
            //GumarIrar(c);
            //Hakarak(c);
            //Gumar1(c);
            //Tarsanun(x);
            //TveriMijin(c);
            //Minimum(c);
            //Stugel(c);
            //ZuygKent(c);
            //StanalTiv(g);
            //Gnahatakan(ch);
            //MetyiGumar(c);
            //ToxiGumar(g);
            //int[]x = Zangvac(a, c);
            //string q = Yerkarutyun(x, s);

            Console.WriteLine("havayi ban");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}          
            Console.ReadLine();
        }
        public static void Datarkqarakusi(int x)
        {
            for (int y = 0; y < x; y++)
            {
                for (int z = 0; z < x; z++)
                {
                    if (y == 0 || y == x - 1 || z == 0 || z == x - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }
        }
        public static void Qarakusi(int x)
        {
            for (int y = 0; y < x; y++)
            {
                for (int z = 0; z < x; z++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
        public static void Barev()
        {//1
            Console.WriteLine("Welcome Friends");
            Console.WriteLine("Have a nice day");
        }
        public static void Imanalanun(string anun)
        {//2
            Console.WriteLine("dzer anuny");
            Console.WriteLine("Welcom friend " + anun);
            Console.WriteLine("Have a nice day");
        }
        public static void Gumar(int n, int n1)
        {//3
            Console.WriteLine(n + n1);
        }
        public static void GumarIrar(int[] y)
        {//4
            int result = 0;
            for (int i = 0; i < y.Length; i++)
            {
                result = result + y[i];
            }
            Console.WriteLine(result);
        }
        public static void Hakarak(int[] y)
        {//5
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i]);
            }
            Console.WriteLine();
            for (int i = y.Length - 1; i >= 0; i--)
            {
                Console.Write(y[i]);
            }
           
        }
        //6*******************************
        public static void Gumar1(int[] y)
        {//7
            int c = 0;
            for(int i = 0;i < y.Length; i++)
            {
                c = c + y[i];
            }
            Console.WriteLine(c);
        }
        public static void Tarsanun(string[] y)
        {//8
            for(int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.WriteLine();
            for (int i = y.Length - 1;i >= 0; i--)
            {
                Console.Write(y[i] + " ");
            }
        }
        public static void TveriMijin(int[] y) 
        {//9
            int c = 0;
            int v = 0;
            for (int i = 0; i < y.Length; i++)
            {
                c = c + y[i];
                v = c / y.Length;
            }
            Console.WriteLine(v);
        }
        public static void Minimum(int[] y)
        {  //10         
            int num = 0;
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (y[i] > y[j])
                    {
                        num = y[i];
                        y[i] = y[j];
                        y[j] = num;
                    }
                }
            }
            Console.WriteLine(y[y.Length - 1]);
        }
        public static void Hakarak1(int[] y) 
        {//11
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i]);
            }
            Console.WriteLine();
            for (int i = y.Length - 1; i >= 0; i--)
            {
                Console.Write(y[i]);
            }
        }
        public static void Stugel(int[] y)
        {//12
            for(int i = 0;i < y.Length; i++)
            {
                if (y[i] > 0)
                {
                    Console.WriteLine("arjeq uni");
                }
                break;
            }
        }
        public static void ZuygKent(int[] x)
        {//13
            int z = 0;
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    z++;
                    Console.Write(x[i]+ " ");
                }
                else if (x[i] % 2 == 1)
                {
                    k++;
                    Console.Write(x[i] + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine(z + " zuyg tver");
            Console.WriteLine(k + " kent tver");
        }
        public static void StanalTiv(int x)
        {//14
            Random random = new Random();
            int[] y = new int[x];

            for (int i = 0; i < y.Length; i++)
            {
                int c = random.Next(1, 100);
                y[i] = c;
                Console.WriteLine(c);
            }          
        }
        public static void Gnahatakan(char x)
        {//15
            switch (x)
            {
                case 'f':
                    Console.WriteLine("Fail");
                    break;
                case 'a':
                    Console.WriteLine("Average");
                    break;
                case 'g':
                    Console.WriteLine("Good");
                    break;
                case 'v':
                    Console.WriteLine("Very Good");
                    break;
                case 'e':
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine("chka tenc gnahatakan");
                    break;
            }
        }
        public static void MetyiGumar(int[] y)
        {//16
            int num = 0;
            int g = 0;

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
                for (int j = 0; j < y.Length; j++)
                {
                    if (y[i] > y[j])
                    {
                        num = y[i];
                        y[i] = y[j];
                        y[j] = num;
                    }
                }
            }
            Console.WriteLine("mety tvernen");
            for (int i = 0; i < 3; i++)
            {
                g = g + y[i];
                Console.WriteLine(y[i]);
            }
            Console.WriteLine("iranc gumary");
            Console.WriteLine(g);
        }
        //17*************************************

        public static void ToxiGumar(int c)
        {//18
            int v = 0;

            while (c > 0)
            {
                v += c % 10;
                c /= 10;
            }
            Console.WriteLine(v);

        }
        //------------------------------------------------

        public static int[] Zangvac(int[]x,int[] y)
        {
            int[] z = new int[x.Length + y.Length];
            int o = 0;
            for (int i = 0;i < x.Length; i++)
            {
                z[i] = x[i];
            }
            for (int i = x.Length;i < z.Length; i++)
            {
                z[i] = y[o];
                o++;
            }

            return z;
        }


        
        //public static string[] Yerkarutyun(string[] x, string[]y)
        //{
        //    string f;
        //    for (int i = 0;i < x.Length; i++)
        //    {
                 
                
        //    } 
            
        //}
    }
}
