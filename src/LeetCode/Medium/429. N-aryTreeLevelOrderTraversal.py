# Definition for a Node.
class Node:
    def __init__(self, val=None, children=None):
        self.val = val
        self.children = children


class Solution:
    #using BFS
    def levelOrder_bfs(self, root: 'Node') -> list[list[int]]:
        result = []
        if root is None:
            return result
        queue = []
        queue.append(root)
        while len(queue) != 0:
            size = len(queue)
            current_list = []
            for i in range(size):
                current = queue.pop(0)
                current_list.append(current.val)
                for child in current.children:
                    queue.append(child)
            result.append(current_list)
        return result
    
    # using DFS
    def levelOrder_dfs(self, root: 'Node') -> list[list[int]]:
        if root is None:
            return []
        dfs_dict = {}
        def dfs(root: Node, height: int):
            if dfs_dict.get(height) is None:
                dfs_dict[height] = [root.val]
            else:
                dfs_dict[height].append(root.val)
            for child in root.children:
                dfs(child, height + 1)
        
        dfs(root, 0)
        result = []
        for key in sorted(dfs_dict.keys()):
            result.append(dfs_dict[key])
        return result
        
