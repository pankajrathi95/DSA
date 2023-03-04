class Solution:
    def combination_sum(self, result, candidates, target, sum, index, current_list):
        if target == sum:
            result.append(current_list.copy())
            return
        
        for i in range(index, len(candidates)):
            if candidates[i] + sum <= target:
                current_list.append(candidates[i])
                self.combination_sum(result, candidates, target, sum + candidates[i], i, current_list)
                current_list.pop()


    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        result = []
        self.combination_sum(result, candidates, target, 0, 0, [])
        return result
        
