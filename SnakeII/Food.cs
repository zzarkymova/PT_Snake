using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Food : GameObject
    {
        public Food()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            this.sign = '@';
        //    this.points.Add(new Point(rnd(40, 40), rnd(40,40)));
        }
    }
}
