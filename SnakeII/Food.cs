﻿using System;
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
 //           Console.BackgroundColor = ConsoleColor.Blue;
            this.sign = '@';
            this.points.Add(new Point(15, 4));
        }
    }
}
