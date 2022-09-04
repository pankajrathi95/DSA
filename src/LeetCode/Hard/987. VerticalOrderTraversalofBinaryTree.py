# Definition for a binary tree node.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

        
class Solution:
    def verticalTraversal(self, root: TreeNode) -> list[list[int]]:
        xy_nodes = []
        def dfs(node, row, column):
            if node is not None:
                xy_nodes.append((column, row, node.val))
                dfs(node.left, row + 1, column - 1)
                dfs(node.right, row + 1, column + 1)
                
            
        dfs(root, 0, 0)
        xy_nodes.sort()
        result = []
        current_col = xy_nodes[0][0]
        current_list = []
        for x, y, z in xy_nodes:
            if x == current_col:
                current_list.append(z)
            else:
                current_col = x
                result.append(current_list)
                current_list = [z]
        result.append(current_list)
        return result
            
                
                
        