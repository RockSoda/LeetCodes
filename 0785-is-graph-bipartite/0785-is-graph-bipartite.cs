public class Solution 
{
    public bool IsBipartite(int[][] graph)
    {
        int m = graph.Length;

        bool?[] colors = new bool?[m];

        for (int verticel = 0; verticel < m; verticel++)
        {
            if (colors[verticel] is not null) continue;
            if (Dfs(verticel, true) is false) return false;
        }

        return true;

        bool Dfs(int verticel, bool color)
        {
            if (colors[verticel] is not null) return colors[verticel] == color;

            colors[verticel] = color;
            int[] adjacentVerticels = graph[verticel];
            foreach (int adjacentVerticel in adjacentVerticels)
            {
                if (Dfs(adjacentVerticel, !color) is false) return false;
            }

            return true;
        }
    }
}