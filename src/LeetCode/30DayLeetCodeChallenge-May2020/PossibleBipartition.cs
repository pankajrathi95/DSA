/*

Given a set of N people (numbered 1, 2, ..., N), we would like to split everyone into two groups of any size.

Each person may dislike some other people, and they should not go into the same group. 

Formally, if dislikes[i] = [a, b], it means it is not allowed to put the people numbered a and b into the same group.

Return true if and only if it is possible to split everyone into two groups in this way.

 

Example 1:

Input: N = 4, dislikes = [[1,2],[1,3],[2,4]]
Output: true
Explanation: group1 [1,4], group2 [2,3]
Example 2:

Input: N = 3, dislikes = [[1,2],[1,3],[2,3]]
Output: false
Example 3:

Input: N = 5, dislikes = [[1,2],[2,3],[3,4],[4,5],[1,5]]
Output: false
 

Note:

1 <= N <= 2000
0 <= dislikes.length <= 10000
1 <= dislikes[i][j] <= N
dislikes[i][0] < dislikes[i][1]
There does not exist i != j for which dislikes[i] == dislikes[j].

*/

using System.Collections.Generic;

public class PossibleBipartition
{
    Dictionary<int, HashSet<int>> map;
    Dictionary<int, int> groups;
    public bool FindPossibleBipartition(int N, int[][] dislikes)
    {

        map = new Dictionary<int, HashSet<int>>();
        groups = new Dictionary<int, int>();
        int m = dislikes.Length;
        for (int i = 1; i <= N; i++)
        {
            map.Add(i, new HashSet<int>());
        }
        for (int i = 0; i < m; i++)
        {
            int from = dislikes[i][0];
            int to = dislikes[i][1];

            map[from].Add(to);
            map[to].Add(from); //essential.
        }
        for (int i = 1; i <= N; i++)
        {
            if (!groups.ContainsKey(i))
            {
                if (dfs(i, 1))
                {
                    //means i and its dislikes belong to different groups
                    //we are good
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
    private bool dfs(int i, int groupId)
    {
        if (groups.ContainsKey(i))
        {
            return groups[i] == groupId;
        }
        groups.Add(i, groupId);


        foreach (int dislike in map[i])
        {
            if (!dfs(dislike, groupId == 1 ? 2 : 1))
                return false;
        }
        return true;
    }
}