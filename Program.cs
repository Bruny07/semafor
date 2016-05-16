using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace conducte
    {
    class Intersectii
    {
        public void Intersecti()
        {
            Thread inter1 = new Thread(new ThreadStart(intersectie1));
            Thread inter2 = new Thread(new ThreadStart(intersectie2));
            inter1.Start();
            inter2.Start();
        }

        public void intersectie1()
        {
            int n = 0;
            while (true)
            {
                n++;
                if (n == 3)
                {
                    Console.WriteLine("Semafor Intersectie 1: Verde");
                    Thread.Sleep(1000);
                    n = 0;
                }
                else
                {
                    Console.WriteLine("Semafor Intersectie 1: Rosu");
                    Thread.Sleep(1000);
                }
                // Thread.CurrentThread.Abort("Final Intersectie 1");
            }
        }
        public void intersectie2()
        {
            int n = 0;
            int culoare;
            while (true)
            {
                n++;
                if (n == 3)
                {
                    // Console.WriteLine("Semafor Intersectie 2: Verde");
                    Thread.Sleep(2000);
                    n = 0;
                    culoare = 1;

                }
                else
                {
                    Console.WriteLine("Semafor Intersectie 2: Rosu");
                    Thread.Sleep(2000);
                    culoare = 0;
                }
                // Thread.CurrentThread.Abort("Final Intersectie 1");
            }

        }

    }

    class Program
        {
          static void Main(string[] args)
        {
            Intersectii p = new Intersectii();
            //  Parallel.Invoke(p.Intersecti);
            p.Intersecti();
            
             
            
        }


        }
}

