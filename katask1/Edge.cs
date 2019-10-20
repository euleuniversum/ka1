using System;
namespace katask1
{
    public class Edge
    {
        public int v1, v2;
        public int weight;

        public Edge(int v1, int v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }
    }
}
