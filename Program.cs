using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10i11Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int max = 0;
            Console.Write("\n\tPodaj liczbę x=");
            x = Convert.ToInt32(Console.ReadLine());
            while (x>0)
                {
                if (x>max) max = x;
                Console.Write("\n\tNajwiększa z podanych liczb jest równa:" + max);
                Console.Write("\n\tPodaj kolejną liczbę x=");
                x = Convert.ToInt32(Console.ReadLine()); ;
                };
            Console.Write("\n\tNaciśnij ENTER, aby zakończyć program");
            Console.ReadLine();
//            return 0;

        }
    }
}
