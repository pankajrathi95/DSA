class Solution:
    @staticmethod
    def fill(grid: list[list[str]], x: int, y: int, m: int, n: int):
        if x < 0 or y < 0 or x >= m or y >= n or grid[x][y] == "0":
            return

        grid[x][y] = "0"
        Solution.fill(grid, x + 1, y, m, n)
        Solution.fill(grid, x, y + 1, m, n)
        Solution.fill(grid, x - 1, y, m, n)
        Solution.fill(grid, x, y - 1, m, n)
    
    def numIslands(self, grid: list[list[str]]) -> int:
        result = 0
        for x in range(len(grid)):
            for y in range(len(grid[x])):
                if grid[x][y] == "1":
                    Solution.fill(grid, x, y, len(grid), len(grid[x]))
                    result += 1
        return result
    
if __name__ == "__main__":
    sol = Solution()
    res = sol.numIslands([["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]])
    print(res)
                    