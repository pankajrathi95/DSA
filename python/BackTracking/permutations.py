class Solution:
    def backtrack(self, result, nums, current_list, index, visited):
        if len(current_list) == len(nums):
            result.append(current_list.copy())
            return

        for i in range(len(nums)):
            if i in visited:
                continue
            current_list.append(nums[i])
            visited.add(i)
            self.backtrack(result, nums, current_list, i + 1, visited)
            current_list.pop()
            visited.remove(i)

    def permute(self, nums: List[int]) -> List[List[int]]:
        result = []
        self.backtrack(result, nums, [], 0, set())
        return result
