#https://leetcode.com/problems/subsets/description/

class Solution:
    def subset(self, nums, result, current_list, index):
        result.append(current_list.copy())
        for i in range(index, len(nums)):
            current_list.append(nums[i])
            self.subset(nums, result, current_list, i + 1)
            current_list.pop()
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []
        self.subset(nums, result, [], 0)
        return result