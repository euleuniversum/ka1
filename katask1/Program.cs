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
            ReadWrite();

        }

        public static void ReadWrite()
        {
            var subStr = File.ReadAllLines("in.txt");
            var numberV = int.Parse(subStr[0]);

            List<Edge> E = new List<Edge>();

            for (int i = 1; i <= numberV; i++)
            {
                int[] V = Array.ConvertAll(Regex.Split(subStr[i], @"\s+"), int.Parse);


                for (int j = 1; j <= numberV; j++)
                {
                    if (V[j-1] != 32767)
                    {
                        var newV = new Edge(i, j, V[j-1]);
                        E.Add(newV);
                    }
                }
            }
            List<Edge> MST = new List<Edge>();

            var result = Prim.AlgorithmByPrim(numberV, E, MST);

            File.WriteAllLines("out.txt", (System.Collections.Generic.IEnumerable<string>)result);

        }
    }
}
