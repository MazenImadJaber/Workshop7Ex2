using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7Ex2
{
    public class Graph
    {
        private int N;
        private int[,] graph;
        private static int INFINITY = int.MaxValue;
        public Graph(int N)
        {
            this.N = N;
            // allocate space for the matrix
            graph =new  int[N, N];
        

            // initialise the matrix to INFINITY
            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    graph[i, j] = INFINITY;
                }
            }
           
        }

        /// Destructor dealloctes the adjacency matrix
        ~Graph()
        {
            graph = null;
        }

        /// Adds an undirected edge to the graph between the source and destination vertices.
        public void addEdge(int src, int dst, int weight)
        {
            graph[src, dst] = weight;
            graph[dst, src] = weight;
        }


        /// Produces a string representation of the graph.
        public static void write(Graph graph)
        {
            for (int i = 0; i < graph.N; i++)
            {
                for (int j = 0; j < graph.N; j++)
                {
                    if (graph.graph[i,j] == INFINITY)
                    {
                        Console.Write("  -");
                    }
                    else
                    {
                        Console.Write("  " + graph.graph[i, j]);
                    }
                   
                }
                Console.Write("\r\n");
            }

        }
    }
}
