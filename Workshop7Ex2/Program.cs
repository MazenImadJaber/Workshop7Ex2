using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = null;
            try
            {
                // read the number of vertices and edges
                sr = new System.IO.StreamReader(args[0]);
                int numVertices, numEdges, src, dst, weight;
                Graph graph = null;
                while (!sr.EndOfStream)
                {
                    numVertices = Int32.Parse(sr.ReadLine().Trim());
                    numEdges = Int32.Parse(sr.ReadLine().Trim());
                    graph = new Graph(numVertices);

                    for (int edge = 0; edge < numEdges; edge++)
                    {
                        String[] tmp = sr.ReadLine().Trim().Replace("\t"," ")
                            .Split(new char[] { ' ' });
                        src = Int32.Parse(tmp[0]);
                        dst = Int32.Parse(tmp[1]);
                        weight = Int32.Parse(tmp[2]);
                        graph.addEdge(src, dst, weight);
                    }

                }
                Graph.write(graph);



            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Could not find file");
            }
            finally
            {
                // close the file
                sr.Close();
                sr = null;
                Console.ReadKey();
            }

        }
    }
}
