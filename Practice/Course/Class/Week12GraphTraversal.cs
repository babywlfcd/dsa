using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Course.Class
{
    public class Week12GraphTraversal
    {
        #region BFS problems

        /// <summary>
        /// Validate if path exist between source and destination for a given graph
        /// BST Traversal
        /// - use flags array for mark visited values
        /// - use queue for traverse all values
        /// T.C -> 
        /// S.C ->
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool PathExist(List<List<int>> l, int s, int d)
        {
            var visited = new bool[l.Count];
            var queue = new Queue<int>();
            queue.Enqueue(s);
            visited[s] = true;

            while (queue.Count > 0)
            {
                int u = queue.Peek();
                queue.Dequeue();

                for (var i = 0; i < l[u].Count; i++)
                {
                    int v = l[u][i];

                    if (visited[v] == false)
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                    }
                }
            }

            return visited[d];
        }

        /// <summary>
        /// Find shortest path between source and destination for a given graph
        /// BST Traversal
        /// - use flags array for mark visited values
        /// - track distance between nodes in the distance int array
        /// - use queue for traverse all values
        /// T.C ->
        /// S.C ->
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int FindShortestPath(List<List<int>> l, int s, int d)
        {
            var visited = new bool[l.Count];
            var distance = new int[l.Count];

            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = -1;
            }

            var queue = new Queue<int>();
            queue.Enqueue(s);
            visited[s] = true;
            distance[s] = 0;

            while (queue.Count > 0)
            {
                int u = queue.Peek();
                queue.Dequeue();

                for (var i = 0; i < l[u].Count; i++)
                {
                    int v = l[u][i];

                    if (visited[v] == false)
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                        distance[v] = distance[u] + 1;
                    }
                }
            }

            return distance[d];
        }

        /// <summary>
        /// Find shortest path between source and destination for a given graph
        /// BST Traversal
        /// - use flags array for mark visited values
        /// - track values of nodes in the path int array
        /// - use queue for traverse all values
        /// T.C ->
        /// S.C ->
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int[] StorePath(List<List<int>> l, int s, int d)
        {
            var visited = new bool[l.Count];
            var path = new int[l.Count];

            for (int i = 0; i < path.Length; i++)
            {
                path[i] = -1;
            }

            var queue = new Queue<int>();
            queue.Enqueue(s);
            visited[s] = true;
            path[s] = -1;

            while (queue.Count > 0)
            {
                int u = queue.Peek();
                queue.Dequeue();

                for (var i = 0; i < l[u].Count; i++)
                {
                    int v = l[u][i];

                    if (visited[v] == false)
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                        path[v] = u;
                    }
                }
            }

            var result = new List<int>();
            result.Add(d);


            for (var i = path.Length; i > 0; i--)
            {

            }

            return path[s..d];
        }

        #endregion

        #region DFS problems 
        public bool TraverseGraph(List<List<int>> l, int u)
        {
            var visited = new bool[l.Count];

            return DFSValidation(u, l, visited);
        }

        private bool DFSValidation(int u, List<List<int>> l, bool[] visited)
        {
            if(visited[u]) return visited[u];
            visited[u] = true;

            for (var i = 0; i < l[u].Count; i++)
            {
                int v = l[u][i];

                if (visited[v] == false)
                    return DFSValidation(v, l, visited);
            }

            return visited[u];
        }

        public int FindConnectedComponents(List<List<int>> l)
        {
            var visited = new bool[l.Count];
            var count = 0;

            for (var i = 1; i < l.Count; i++)
            {
                if (visited[i] == false)
                {
                    var t = DFS(i, l, visited, count);
                    count += t;

                }
            }

            return count;
        }

        private int DFS(int u, List<List<int>> l, bool[] visited, int count)
        {
            if (visited[u]) return count;
            visited[u] = true;

            for (var i = 0; i < l[u].Count; i++)
            {
                int v = l[u][i];

                if (visited[v] == false)
                {
                    DFS(v, l, visited, count);
                    count++;
                }
            }

            return count;
        }


        #endregion
    }
}
