namespace Practice.Course.Assignments
{
    public class GraphsAssignment
    {
        /// <summary>
        /// 1. Path in Directed Graph
        ///     Validate if path exist between source and destination for a given graph
        /// Solution: BST Traversal
        /// - use flags array for mark visited values
        /// - use queue for traverse all values
        /// T.C -> O(E)
        /// S.C -> O(E * N)
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
    }
}
