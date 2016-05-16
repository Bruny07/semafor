using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pipestream
{
    class Intersectii
    {
        public void Intersecti()
        {
            Thread interCosm = new Thread(new ThreadStart(IntersectieCosminului.intersectie));
            Thread interSalc = new Thread(new ThreadStart(IntersectieSalcamilor.intersectie));
            interCosm.IsBackground = false;
            interSalc.IsBackground = false;
            interCosm.Start();
            interSalc.Start();
        }
    }
    
    class IntersectieCosminului
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            { 
                if (semInainte == 0)
                {
                    semInainte = 1;
                     Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if(semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }
                // Thread.CurrentThread.Abort("Final Intersectie 1");
            }
        }
    }

    class IntersectieSalcamilor
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }  
            }
        }
    }

    class IntersectieDrubeta
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }
            }
        }
    }
    class IntersectieTraiana
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }
            }
        }
    }
    class IntersectieBrancoveanu
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }
            }
        }
    }
    class IntersectieHebe
    {
        public static int semInainte = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
                    Thread.Sleep(5000);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int contor = 0;
            Intersectii p = new Intersectii();
            //Parallel.Invoke(p.Intersecti);
            p.Intersecti();
            //while (true)
            //{

            //    if (Intersectie2.culoare == 1 && contor == 50000000)
            //    {
            //        Console.WriteLine("Intersectie 1: Verde");
            //        contor = 0;
            //        //continue;
            //    }
            //    else if (Intersectie2.culoare == 0 && contor == 50000000)
            //    {
            //        Console.WriteLine("Intersectie 1: Rosu");
            //        contor = 0;
            //       // continue;
            //    }
            //    contor++;
            //}
        }
    }
}
