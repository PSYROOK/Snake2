using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            var p2 = new Point(4, 5, '#');
            p2.Drow();

           /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Drow(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Drow(x2, y2, sym2);*/

            Console.ReadKey();
        }
    }
}
