#leetcode - https://leetcode.com/problems/combinations/description/

class Solution:
    def comb(self, nums, result, current_list, index, visited, k):
        if len(current_list) == k:
            result.append(current_list.copy())
        for i in range(index, len(nums)):
            if i not in visited:
                visited.add(i)
                current_list.append(nums[i])
                self.comb(nums, result, current_list, i + 1, visited, k)
                current_list.pop()
                visited.remove(i)

    def combine(self, n: int, k: int) -> List[List[int]]:
        nums = [(i + 1) for i in range(n)]
        result = []
        self.comb(nums, result, [], 0, set(), k)
        return result
