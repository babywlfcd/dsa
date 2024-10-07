using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Graphs
{
    public class GraphMatrix
    {
        private readonly int _vertices;
        private int[][] _adjacencyMatrix;

        public GraphMatrix(int vertices)
        {
            _vertices = vertices;
        }

        public int[][] CreateAdjacencyMatrix()
        {
            _adjacencyMatrix = new int[_vertices + 1][];
            for (var i = 0; i <= _vertices; i++)
                _adjacencyMatrix[i] = new int[_vertices + 1];

            
            return _adjacencyMatrix;
        }

        public void AddEdgeUnWeightedUndirected(int source, int destination)
        {
            _adjacencyMatrix[source][destination] = 1;
            _adjacencyMatrix[destination][source] = 1;
        }

        public void AddEdgeUnWeightedDirected(int source, int destination)
        {
            _adjacencyMatrix[source][destination] = 1;
        }

        public void AddEdgeWeightedUndirected(int source, int destination, int weight)
        {
            _adjacencyMatrix[source][destination] = weight;
            _adjacencyMatrix[destination][source] = weight;
        }

        public void AddEdgeWeightedDirected(int source, int destination, int weight)
        {
            _adjacencyMatrix[source][destination] = weight;
        }

        public string PrintGraph()
        {
            var n = _adjacencyMatrix.Length;
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                
                for (var j = 0; j < n; j++)
                    sb.Append($"{_adjacencyMatrix[i][j]} ");

                sb.AppendLine();
                
            }
            return sb.ToString();
        }
    }
}
