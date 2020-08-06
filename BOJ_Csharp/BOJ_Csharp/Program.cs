using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJ_Csharp
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X.ToString() + " " + Y.ToString();
        }


    }

    class Program
    {
        static void Solution_11650()
        {
            int N = int.Parse(Console.ReadLine());
            var arr = new Vector[N];
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split();
                arr[i] = new Vector(int.Parse(input[0]), int.Parse(input[1]));
            }

            arr = arr.ToList().OrderBy(v => v.X).ThenBy(v => v.Y).ToArray();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }




        static void Main(string[] args)
        {
            Solution_11650();
        }
    }
}
