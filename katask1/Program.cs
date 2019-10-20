using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace katask1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Read()
        {
            var subStr = File.ReadAllLines("in.txt");
            var numberV = int.Parse(subStr[0]);

            List<Edge> E = new List<Edge>();

            for (int i = 0; i < numberV; i++)
            {
                int[] V = Array.ConvertAll(Regex.Split(subStr[i], @"\s+"), int.Parse);


                for (int j = 0; j < numberV; j++)
                {
                    if (V[j] != 32767)
                    {
                        var newV = new Edge(i, j, V[j]);
                        E.Add(newV);
                    }
                }
            }


            //var result = Prim.AlgorithmByPrim(numberV, E, MST);

            //File.WriteAllLines("out.txt", result);
        
    }
}
