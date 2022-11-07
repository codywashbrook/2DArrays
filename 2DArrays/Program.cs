using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays/Multi-Dimensional");
            Console.WriteLine();

            //single value
            int score = 100;

            //array
            int[] ammo = new int[4];
            ammo[0] = 1;
            ammo[1] = 20;
            ammo[2] = 35;
            ammo[3] = 4;

            //2D array of 2D map
            int[,] map = new int[20, 10]; //200 values //loop for the x, y, loop x from 0 - 19, loop y 
            map[0, 0] = 0;
            map[1, 0] = 0;
            map[2, 0] = 0;

            //,,
            map[19, 9] = 0;
            
            // coint from 1..10
            int i = 1; //start
            while (i <= 10) // end
            {
                Console.WriteLine(i);
                i = i + 1; // increment
            }
            i = 1; //start // reset after og i finsished
            while (i <= 10) // end
            {
                Console.WriteLine(i);
                i = i + 1; // increment
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
