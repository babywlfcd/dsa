using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice
{
    public class GraphsPractice
    {
        /// <summary>
        /// Easy
        /// 1791. Find Center of Star Graph
        /// https://leetcode.com/problems/find-center-of-star-graph/description/
        /// Solution: compare only first 2 nodes to identify the center of the star graph
        /// T.C = O(1)
        /// S.C = O(1)
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public int FindCenter(int[][] edges)
        {
            // we need to compair only first 2 nodes
            if (edges[0][0] == edges[1][1] || edges[0][0] == edges[1][0])
                return edges[0][0];

            else return edges[0][1];

        }

        #region Valid path
        private List<List<int>> graph = new List<List<int>>();

        /// <summary>
        /// Easy
        /// https://leetcode.com/problems/find-if-path-exists-in-graph/
        /// 1971. Find if Path Exists in Graph
        /// Solution: BFS
        /// T.C = O(V + E)
        /// S.C = O(V + E)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            BuildGraph(n, edges);

            //has path
            var visited = new bool[n];
            var queue = new Queue<int>();
            queue.Enqueue(source);
            visited[source] = true;

            while (queue.Count > 0)
            {
                int currentNode = queue.Peek();
                queue.Dequeue();
                if (currentNode == destination)
                    return true;

                foreach (var neighbor in graph[currentNode])
                {
                    if (visited[neighbor] == false)
                    {
                        queue.Enqueue(neighbor);
                        visited[neighbor] = true;
                    }
                }
            }

            return visited[destination];
        }

        /// <summary>
        /// Build undirected graph with ajacency list
        /// S.C: O(V + E)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        private void BuildGraph(int n, int[][] edges)
        {
            for (int i = 0; i < n; i++)
            {
                graph.Add(new List<int>());
            }

            foreach (var edge in edges)
            {
                AddEdge(edge[0], edge[1]);
            }
        }

        private void AddEdge(int i, int j)
        {
            graph[i].Add(j);
            graph[j].Add(i);
        }
        # endregion 
        /*Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        public bool ValidPath1(int n, int[][] edges, int s, int d)
        {
            BuildGraph(edges);
            return HasPath(s, d);
        }

        public void addEdge(int i, int j)
        {
            if (!graph.ContainsKey(i))
            {
                graph[i] = new List<int>();
            }
            if (!graph.ContainsKey(j))
            {
                graph[j] = new List<int>();
            }

            graph[i].Add(j);
            graph[j].Add(i);
        }

        public void BuildGraph(int[][] edges)
        {
            foreach (var edge in edges)
            {
                addEdge(edge[0], edge[1]);
            }
        }

        public bool HasPath(int s, int d)
        {
            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(s);
            visited.Add(s);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();

                if (currentNode == d)
                {
                    return true;
                }

                foreach (var neighbor in graph[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return false;
        }*/
    }
}
