def is_safe(n, matrix, i, j):
    if i >= 0 and i < n and j >= 0 and j < n and matrix[i][j] == -1:
        return True
    return False

def knight_tour(n, matrix, possible_moves, i, j, count):
    if count == n ** 2:
        return True

    for k in range(len(possible_moves)):
        new_i = i + possible_moves[k][0]
        new_j = j + possible_moves[k][1]
        if is_safe(n, matrix, new_i, new_j):
            matrix[new_i][new_j] = count
            if knight_tour(n, matrix, possible_moves, new_i, new_j, count + 1):
                return True

            matrix[new_i][new_j] = -1
    return False


if __name__ == "__main__":
    n = 8
    matrix = [[-1 for x in range(n)] for y in range(n)]
    possible_moves = [[1,2],[1,-2],[-1,2],[-1,-2],[2,1],[-2,1],[2,-1],[-2,-1]]
    matrix[0][0] = 0
    count = 1
    is_possible = knight_tour(n, matrix, possible_moves, 0, 0, count)
    print(matrix)
    print(is_possible)
