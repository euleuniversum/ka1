using System;
using System.IO;

namespace katask1
{
    class ReadWrite
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Read()
        {
            var subStr = File.ReadAllLines("in.txt");
            //ComponentsBound.N = int.Parse(subStr[0]);
            //ComponentsBound.G = new int[ComponentsBound.N][];

            //for (int i = 0; i < ComponentsBound.N; i++)
            //{
            //    for (int j = 0; j < ComponentsBound.N; j++)
            //    {
            //        if (subStr[i + 1].Contains((j + 1).ToString()))
            //            ComponentsBound.G[i][j] = 1;
            //        else
            //            ComponentsBound.G[i][j] = 0;
            //    }
            //}
            //ComponentsBound.FindComponents();

            File.WriteAllLines("out.txt", vertexList);
        }
    }
}
