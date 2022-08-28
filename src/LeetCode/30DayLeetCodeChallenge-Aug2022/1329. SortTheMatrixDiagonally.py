class Solution:
    def diagonalSort(self, mat: list[list[int]]) -> list[list[int]]:
        xy_value = {}
        for x in range(0, len(mat)):
            for y in range(0, len(mat[x])):
                current = x - y
                if xy_value.get(current) is None:
                    xy_value[current] = []
                xy_value[current].append(mat[x][y])
        
        for key in xy_value:
            xy_value[key] = sorted(xy_value[key])

        for x in range(0, len(mat)):
            for y in range(0, len(mat[x])):
                mat[x][y] = xy_value.get(x - y).pop(0)
        return mat


if __name__ == "__main__":
    sol = Solution()
    print(sol.diagonalSort([[3,3,1,1],[2,2,1,2],[1,1,1,2]]))