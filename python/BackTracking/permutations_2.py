class Solution:
    def permute(self, nums, result, current_list, index, visited):
        if len(current_list) == len(nums):
            result.append(current_list.copy())
            return

        for i in range(len(nums)):
            if i not in visited:
                visited.add(i)
                current_list.append(nums[i])
                self.permute(nums, result, current_list, i + 1, visited)
                current_list.pop()
                visited.remove(i)
    def permuteUnique(self, nums: List[int]) -> List[List[int]]:
        result = []
        nums.sort()
        self.permute(nums, result, [], 0, set())
        visited = set()
        new_result = []
        for ele in result:
            sorted_val = ''.join(str(e) for e in ele)
            if sorted_val not in visited:
                visited.add(sorted_val)
                new_result.append(ele)
        return new_result
