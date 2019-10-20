using System;
using System.Collections.Generic;

namespace katask1
{
    public class Prim
    {
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
            notUsedV.RemoveAt(usedV[0]);

            while (notUsedV.Count > 0)
            {
                int minE = int.MaxValue; //номер наименьшего ребра
                                         //поиск наименьшего ребра
                Edge vMinE;
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if (usedV.Contains(notUsedE[i].v1))
                    {
                        if (minE >= notUsedE[i].weight)
                        {
                            minE = notUsedE[i].weight;
                            vMinE = notUsedE[i];
                        }
                    }
                }
                //заносим новую вершину в список использованных и удаляем ее из списка неиспользованных
                if (minE != int.MaxValue)
                {
                    usedV.Add(vMinE.v2);
                    notUsedV.Remove(vMinE.v2);
                }

                //заносим новое ребро в дерево и удаляем его из списка неиспользованных
                MST.Add(vMinE);
                notUsedE.Remove(vMinE);
            }
            return MST;
        }
    }
}
