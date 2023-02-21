# In a given matrix a rat can travel forward and down. The matrix is a maze where 0 means blocked and 1 is open. give the 
# path for the rat so that it can move from top left to bottom right

def is_safe(maze, res, x, y, m, n):
    if x >= 0 and x < m and y >= 0 and y < n and maze[x][y] == 1 and res[x][y] == 0:
        return True
    return False

def rat_maze(maze, res, possible_moves, x, y, m, n):
    if x == m - 1 and y == n - 1:
        return True

    for k in range(len(possible_moves)):
        new_x = x + possible_moves[k][0]
        new_y = y + possible_moves[k][1]
        if is_safe(maze, res, new_x, new_y, m, n):
            res[new_x][new_y] = 1
            if rat_maze(maze, res, possible_moves, new_x, new_y, m, n):
                return True
            res[new_x][new_y] = 0
    return False

if __name__ == "__main__":
    maze = [[1,0,0,0], [1,1,0,1], [0,1,0,0], [1,1,1,1]]
    m = 4
    n = 4
    possible_moves = [[1, 0], [0,1]]
    res = [[0 for x in range(m)] for y in range(n)]
    res[0][0] = 1
    print(rat_maze(maze, res, possible_moves, 0, 0, m, n))
    print(res)
