# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def goodNodes(self, root: TreeNode) -> int:
        def dfs(root: TreeNode, currentMax:int):
            count = 0
            if root is None:
                return 0
            if root.val >= currentMax:
                currentMax = root.val
                count = 1
            return count + dfs(root.left, currentMax) + dfs(root.right, currentMax)
        
        return dfs(root, -10000)
