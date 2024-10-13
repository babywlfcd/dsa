using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Graphs
{
    public class GraphList
    {
        private readonly int _vertices;
        private readonly int[][] _edges;
        private List<List<int>> _adjacencyList = new List<List<int>>();
        private List<List<(int, int)>> _adjacencyListWheighted = new List<List<(int, int)>>();

        public GraphList(int vertices, int[][] edges)
        {
            _vertices = vertices;
            _edges = edges;
        }

        public List<List<int>> CreateAdjacencyList()
        {
            // if  we want to not handle 0 based index we can create a list of size vertices + 1
            // i <= _vertices
            for (var i = 0; i < _vertices; i++)
            {
                _adjacencyList.Add(new List<int>());
            }

            return _adjacencyList;
        }

        public List<List<int>> CreateAdjacencyListUnWeightedUndirected()
        {
            // if  we want to not handle 0 based index we can create a list of size vertices + 1
            // i <= _vertices
            for (var i = 0; i < _vertices; i++)
            {
                _adjacencyList.Add(new List<int>());
            }

            foreach (var edge in _edges)
            {
                AddEdgeUnWeightedUndirected(edge[0], edge[1]);
            }

            return _adjacencyList;
        }

        public List<List<int>> CreateAdjacencyListWheighted()
        {
            // if  we want to not handle 0 based index we can create a list of size vertices + 1
            // i <= _vertices
            for (var i = 0; i < _vertices; i++)
            {
                _adjacencyListWheighted.Add(new List<(int, int)>());
            }

            return _adjacencyList;
        }

        /// <summary>
        /// if  we want to not handle 0 based index we can create a list of size vertices + 1
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdgeUnWeightedUndirected(int source, int destination)
        {
            // if  we want to not handle 0 based index we can create a list of size vertices + 1
            // _adjacencyList[source].Add(destination);
            // _adjacencyList[destination].Add(source);
            _adjacencyList[source - 1].Add(destination);
            _adjacencyList[destination - 1].Add(source);
        }

        public void AddEdgeUnWeightedDirected(int source, int destination)
        {
            _adjacencyList[source - 1].Add(destination);
        }

        public void AddEdgeWeightedUndirected(int source, int destination, int weight)
        {
            _adjacencyListWheighted[source - 1].Add((destination, weight));
            _adjacencyListWheighted[destination - 1].Add((source, weight));
        }

        public void AddEdgeWeightedDirected(int source, int destination, int weight)
        {
            _adjacencyListWheighted[source - 1].Add((destination, weight));
        }

        public string PrintGraph()
        {
            var n = _adjacencyList.Count;
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                sb.Append($"{i}: ");
                foreach (var item in _adjacencyList[i])
                    sb.Append($"{item} ");
                sb.AppendLine();
            }

            return sb.ToString();
        }
        public string PrintGraphWeight()
        {
            var n = _adjacencyListWheighted.Count;
            var sb = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                sb.Append($"{i}: ");
                foreach (var item in _adjacencyListWheighted[i])
                    sb.Append($"{item} ");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
