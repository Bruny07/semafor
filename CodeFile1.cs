using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semafoare
{
    class Program
    {
        static void Main(string[] args)
        {
            int contor = 0;
            semafor.Intersectii p = new semafor.Intersectii();
            //Parallel.Invoke(p.Intersecti);
            p.Intersecti();
            
            while (true)
            {
                

                if (semafor.IntersectieCosminului.semInainte == 1 && contor == 100000)
                {
                    Console.WriteLine("Intersectie 1: Verde");
                    contor = 0;
                    //continue;
                }
                else if (semafor.IntersectieCosminului.semInainte == 0 && contor ==  100000)
                {
                    Console.WriteLine("Intersectie 1: Rosu");
                    contor = 0;
                    // continue;
                }
                contor++;
            }
        }
    }
}