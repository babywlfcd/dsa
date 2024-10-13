using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
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
    }
}
