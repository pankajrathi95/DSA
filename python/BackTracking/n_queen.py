import copy
def is_safe(matrix, row, col, n):
    # check if any Q exists in same row
    for i in range(n):
        if i != row and matrix[i][col] == 'Q':
            return False
    
    # check if any Q exists in same column
    for i in range(n):
        if i != col and matrix[row][i] == 'Q':
            return False
    
    # check for diagonals if Q exists
    possible_moves = [[1,1], [-1, -1], [1, -1], [-1, 1]]
    for x in range(len(possible_moves)):
        new_x = row
        new_y = col
        for y in range(n):
            new_x += possible_moves[x][0]
            new_y += possible_moves[x][1]
            if not (new_x >= 0 and new_x < n and new_y >= 0 and new_y < n):
                break
            if matrix[new_x][new_y] == 'Q':
                return False
    
    return True
            
    
def queen_solve(matrix, n, row, result):
    if row == n:
        new_val = copy.deepcopy(matrix)
        result.append(new_val)
    
    for i in range(n):
        if is_safe(matrix, row, i, n):
            matrix[row][i] = 'Q'
            queen_solve(matrix, n, row + 1, result)
            matrix[row][i] = '.'
    
def n_queen(n):
    # code here
    matrix = [['.' for x in range(n)] for y in range(n)]
    result = []
    queen_solve(matrix, n, 0, result)
    print(result)

if __name__ == "__main__":
    n_queen(4)