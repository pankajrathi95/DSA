class Solution:
    def dfs(self, left, right, s, n, result):
        if len(s) == n * 2:
            result.append(s)
            return
        
        if left < n:
            self.dfs(left + 1, right, s + "(", n, result)
        if right < left:
            self.dfs(left, right + 1, s + ")", n, result)
    def generateParenthesis(self, n: int) -> List[str]:
        result = []
        self.dfs(0, 0, "", n, result)
        return result
