# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def averageOfLevels(self, root: Optional[TreeNode]) -> List[float]:
        q = []
        q.append(root)
        res = []
        while (len(q) != 0):
            size = len(q)
            sum = 0
            for i in range(size):
                current = q.pop(0)
                sum += current.val
                if current.left is not None:
                    q.append(current.left)
                if current.right is not None:
                    q.append(current.right)
            res.append(sum / size)
        return res
