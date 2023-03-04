class Solution:
    def combination_sum(self, result, candidates, target, sum, index, current_list):
        if target == sum:
            result.append(current_list.copy())
            return

        for i in range(index, len(candidates)):
            if i > index and candidates[i] == candidates[i - 1]:
                continue
            if candidates[i] + sum <= target:
                current_list.append(candidates[i])
                self.combination_sum(result, candidates, target, candidates[i] + sum, i + 1, current_list)
                current_list.pop()

    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        result = []
        self.combination_sum(result, candidates, target, 0, 0, [])
        visited = set()
        new_result = []
        for ele in result:
            ele.sort()
            sorted_val = ''.join(str(e) for e in ele)
            if sorted_val not in visited:
                visited.add(sorted_val)
                new_result.append(ele)
        return new_result
