using System;
using System.Collections.Generic;

namespace Practice__10
{
    class Graph<T>
    {
        public List<List<int>> Matrix { get; }
        public int Count { get; private set; }
        public List<T> Inform { get; }
        public Graph(int count, string[] input, List<T> inform)
        {
            Count = count;
            Inform = inform;
            Matrix = MakeMatrix(Count);
            foreach (string edge in input)
            {
                Matrix[Convert.ToInt32(Char.ToString(edge[0]))][Convert.ToInt32(Char.ToString(edge[1]))] = 1;
                Matrix[Convert.ToInt32(Char.ToString(edge[1]))][Convert.ToInt32(Char.ToString(edge[0]))] = 1;
            }
        }

        private static List<List<int>> MakeMatrix(int count)
        {
            List<List<int>> matrix = new List<List<int>>(count);
            for (int i = 0; i < count; i++)
            {
                matrix.Add(new List<int>(count));
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    matrix[i].Add(0);
                }
            }

            return matrix;
        }

        public void DelPoints(T inform)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Inform[i].Equals(inform))
                {
                    for (int j = 0; j < Count; j++)
                    {
                        Matrix[j].RemoveAt(i);
                    }
                    Matrix.RemoveAt(i);

                    Count--;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    Console.Write(Matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}