using System;
using System.Collections.Generic;
using System.Linq;

namespace katask1
{
    public class Prim
    {
        public static int sumWeight = 0;

        public static List<Edge> AlgorithmByPrim(int numberV, List<Edge> E, List<Edge> MST)
        {
            //неиспользованные ребра
            List<Edge> notUsedE = new List<Edge>(E);
            //использованные вершины
            List<int> usedV = new List<int>();
            //неиспользованные вершины
            List<int> notUsedV = new List<int>();

            for (int i = 1; i <= numberV; i++)
                notUsedV.Add(i);

            usedV.Add(1);
            notUsedV.Remove(usedV[0]);

            while (notUsedV.Count > 0)
            {
                int minE = int.MaxValue;
                int numbE = int.MaxValue; //номер наименьшего ребра
                                         //поиск наименьшего ребра
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if ((usedV.Contains(notUsedE[i].v1)))
                    {
                        if (minE >= notUsedE[i].weight)
                        {
                            minE = notUsedE[i].weight;
                            numbE = i;
                        }
                    }
                }
                //заносим новую вершину в список использованных и удаляем ее из списка неиспользованных
                if (minE != int.MaxValue && (usedV.IndexOf(notUsedE[numbE].v1) != -1 || usedV.IndexOf(notUsedE[numbE].v2) != -1))
                {
                    usedV.Add(notUsedE[numbE].v2);
                    notUsedV.Remove(notUsedE[numbE].v1);
                    sumWeight += minE;
                }
                MST.Add(notUsedE[numbE]);
                notUsedE.Remove(notUsedE[numbE]);
                //заносим новое ребро в дерево и удаляем его из списка неиспользованных

            }

            var sortedMST = from u in MST
                            orderby u.v1, u.v2
                            select u;
            List<Edge> result = sortedMST.ToList();
            sumWeight = Math.Abs(sumWeight)/2;
            return result;
        }
    }
}
