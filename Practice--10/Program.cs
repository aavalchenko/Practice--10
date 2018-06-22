using System;
using System.Collections.Generic;
using InputOutputLib;

namespace Practice__10
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = MakeGraph(Get.Int32("Введите количество вершин графа (нумеруются с нуля): ", 1));

            graph.DelPoints(Get.Int32("Введите значение информационного поля для удаления: "));
            graph.Print();
            Console.ReadKey();
        }

        private static Graph<int> MakeGraph(int count)
        {
            string[] edges = Get.String("Введите ребра в виде <начало><конец>, разделяя каждое пробелом: ").Split(' ');
            List<int> infoms = new List<int>();
            for (int i = 0; i < count; i++)
            {
                infoms.Add(Get.Int32($"Ведите значение для {i} вершины графа: "));
            }
            return new Graph<int>(count, edges, infoms);
        }
    }
}
