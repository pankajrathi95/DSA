class Solution:
    def is_safe(self, board, row, col, current_char):
        # in that row
        for i in range(9):
            if board[row][i] == current_char:
                return False
        
        # in that column
        for i in range(9):
            if board[i][col] == current_char:
                return False

        # in that grid
        start_row = row - row % 3
        start_col = col - col % 3
        for i in range(3):
            for j in range(3):
                if board[i + start_row][j + start_col] == current_char:
                    return False

        return True

    def solve_sudoku(self, board, row, col):
        if row == 9:
            return True
        if col == 9:
            return self.solve_sudoku(board, row + 1, 0)

        if board[row][col] != '.':
            return self.solve_sudoku(board, row, col + 1)
        for i in range(1, 10):
            if (self.is_safe(board, row, col, str(i))):
                board[row][col] = str(i)
                if self.solve_sudoku(board, row, col + 1):
                    return True
                board[row][col] = '.'
        return False

                
    def solveSudoku(self, board: List[List[str]]) -> None:
        """
        Do not return anything, modify board in-place instead.
        """
        self.solve_sudoku(board, 0,0)

if __name__ == "__main__":
    s = Solution()
    board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
    s.solveSudoku(board)
    print(board)