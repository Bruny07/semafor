using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semafor
{
    class Intersectii
    {
        public void Intersecti()
        {
            Thread interCosm = new Thread(new ThreadStart(IntersectieCosminului.intersectie)); interCosm.IsBackground = true; interCosm.Start();
            Thread interSalc = new Thread(new ThreadStart(IntersectieSalcamilor.intersectie)); interSalc.IsBackground = true; interSalc.Start();
            Thread interDrub = new Thread(new ThreadStart(IntersectieDrubeta.intersectie)); interDrub.IsBackground = true; interDrub.Start();
            Thread interTrai = new Thread(new ThreadStart(IntersectieTraiana.intersectie)); interTrai.IsBackground = true; interTrai.Start();
            Thread interBran = new Thread(new ThreadStart(IntersectieBrancoveanu.intersectie)); interBran.IsBackground = true; interBran.Start();
            Thread interHebe = new Thread(new ThreadStart(IntersectieHebe.intersectie)); interHebe.IsBackground = true; interHebe.Start();
            Thread interRane = new Thread(new ThreadStart(IntersectieRanetii.intersectie)); interRane.IsBackground = true; interRane.Start();
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
                    //Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if(semInainte == 1)
                {
                    semInainte = 0;
                    //Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
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
                    //Console.WriteLine("Semafor Intersectie Cosminului: Verde");
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    //Console.WriteLine("Semafor Intersectie Cosminului: Rosu");
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
        public static int semStanga = 0;
        public static void intersectie()
        {
            while (true)
            {
                if (semInainte == 0)
                {
                    semInainte = 1;
                    semStanga = 0;
                    Thread.Sleep(5000);
                }
                else if (semInainte == 1)
                {
                    semInainte = 0;
                    semStanga = 1;
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
    class IntersectieRanetii
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



    
}
