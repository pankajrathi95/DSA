# This is a variation to rat_in_a_maze.py problem. The rat can move in all 4 directions
# Find all the Possible paths. Print the path in this fashion below - 'U'(up), 'D'(down), 'L' (left), 'R' (right)
# Input:
# N = 4
# m[][] = {{1, 0, 0, 0},
#          {1, 1, 0, 1}, 
#          {1, 1, 0, 0},
#          {0, 1, 1, 1}}
# Output:
# DDRDRR DRDDRR
# Explanation:
# The rat can reach the destination at 
# (3, 3) from (0, 0) by two paths - DRDDRR 
# and DDRDRR, when printed in sorted order 
# we get DDRDRR DRDDRR.

def is_safe(visited, m, x, y, n):
        if x >= 0 and x < n and y >= 0 and y < n and visited[x][y] == 0 and m[x][y] == 1:
            return True
        return False
        
def get_direction(val):
    if val == 0:
        return "U"
    elif val == 1:
        return "D"
    elif val == 2:
        return "R"
    else:
        return "L"
        
def rec_findPath(visited, m, n, x, y, possible_moves, result, strr):
    if x == n - 1 and y == n - 1:
        result.append(strr)
    
    for k in range(len(possible_moves)):
        new_x = x + possible_moves[k][0]
        new_y = y + possible_moves[k][1]
        if is_safe(visited, m, new_x, new_y, n):
            visited[new_x][new_y] = 1
            strr += get_direction(k)
            rec_findPath(visited, m, n, new_x, new_y, possible_moves, result, strr)
            strr = strr[:len(strr)-1]
            visited[new_x][new_y] = 0

def findPath(m, n):
    # code here
    visited = [[0 for x in range(n)] for y in range(n)]
    visited[0][0] = 1
    possible_moves = [[-1, 0], [1, 0], [0, 1], [0, -1]]
    result = []
    if m[0][0] == 0:
        print("-1")
        return
    rec_findPath(visited, m, n, 0, 0, possible_moves, result, "")
    print(result)


if __name__ == "__main__":
    findPath([[1,1], [1,1]], 2)
