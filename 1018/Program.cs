using System;
using System.Linq;

namespace _1018
{
    class Program
    {
        static readonly char[] WB = "WBWBWBWB".ToArray();
        static readonly char[] BW = "BWBWBWBW".ToArray();


        static void Main(string[] args)
        {
            var n_and_m = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
            int n = n_and_m[0];
            int m = n_and_m[1];

            var rawChessBoard = new string[n];
            for (int k = 0; k < n; k++){
                rawChessBoard[k] = Console.ReadLine();
            }

            var result = int.MaxValue;
            for (int i = 0; i < n - 7; i++)
            {   
                for (int j = 0; j < m - 7; j++)
                {
                    var chess = SelectChessBoard(i, j, rawChessBoard);
                    var paintRequired = CheckChessBoard(chess);
                    if (paintRequired < result) result = paintRequired;
                }
            }
            Console.WriteLine(result);
        }

        private static int CheckChessBoard(string[] chess)
        {
            int wbResult = CheckWB(chess);
            int bwResult = CheckBW(chess);
            //Console.WriteLine(Math.Min(wbResult, bwResult));
            return Math.Min(wbResult, bwResult);
        }

        private static int CheckBW(string[] chess)
        {
            int paintRequired = 0;
            for (int i = 0; i < 8; i++)
            {
                var reference = i % 2 == 0 ? BW : WB;
                paintRequired += CheckDifference(chess[i], reference);
            }
            return paintRequired;
        }

        private static int CheckWB(string[] chess)
        {
            int paintRequired = 0;
            for (int i = 0; i < 8; i++)
            {
                var reference = i % 2 == 0 ? WB : BW;
                //Console.WriteLine("i: " + i.ToString());
                //Console.WriteLine(chess[i]);
                paintRequired += CheckDifference(chess[i], reference);
                
            }
            return paintRequired;
        }

        private static int CheckDifference(string v, char[] reference)
        {
            //Console.WriteLine("ref: " + reference[0]);
           // Console.WriteLine("value: " + v);
            int diff = 0;
            
            for (int i = 0; i < 8; i++)
            {
                if (v[i].Equals(reference[i]))
                {
                    continue;
                }
                diff += 1;
            }
            //Console.WriteLine("diff: " + diff.ToString());
            return diff;
        }

        private static string[] SelectChessBoard(int i, int j, string[] rawChessBoard)
        {
            string[] selectedRow = new string[8];
            Array.Copy(rawChessBoard, i, selectedRow, 0, 8);

            string[] result = new string[8];
            for (int index = 0; index < 8; index++)
            {
                var row = selectedRow[index];
                result[i] = row.Substring(j, 8);
            }
            

            return result;

        }
    }
}
