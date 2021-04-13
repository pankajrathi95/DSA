/*
#341 - https://leetcode.com/problems/flatten-nested-list-iterator/

You are given a nested list of integers nestedList. Each element is either an integer or a list whose elements may also be integers or other lists. Implement an iterator to flatten it.

Implement the NestedIterator class:

NestedIterator(List<NestedInteger> nestedList) Initializes the iterator with the nested list nestedList.
int next() Returns the next integer in the nested list.
boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.
 

Example 1:

Input: nestedList = [[1,1],2,[1,1]]
Output: [1,1,2,1,1]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,1,2,1,1].
Example 2:

Input: nestedList = [1,[4,[6]]]
Output: [1,4,6]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,4,6].
 

Constraints:

1 <= nestedList.length <= 500
The values of the integers in the nested list is in the range [-106, 106].
*/


using System.Collections.Generic;
/**
* // This is the interface that allows for creating nested lists.
* // You should not implement it, or speculate about its implementation
* 
*/
public interface NestedInteger
{

    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    bool IsInteger();

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    int GetInteger();

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    IList<NestedInteger> GetList();
}

public class NestedIterator
{
    IList<int> result;
    int index;
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        result = new List<int>();
        index = 0;
        AddValues(nestedList);
    }

    private void AddValues(IList<NestedInteger> nestedList)
    {
        for (int i = 0; i < nestedList.Count; i++)
        {
            if (nestedList[i].IsInteger())
            {
                result.Add(nestedList[i].GetInteger());
            }
            else
            {
                AddValues(nestedList[i].GetList());
            }

        }
    }

    public bool HasNext()
    {
        return index < result.Count;
    }

    public int Next()
    {
        return result[index++];
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */