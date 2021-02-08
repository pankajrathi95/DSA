/*
#284 - https://leetcode.com/problems/peeking-iterator/

Given an Iterator class interface with methods: next() and hasNext(), design and implement a PeekingIterator that support the peek() operation -- it essentially peek() at the element that will be returned by the next call to next().

Example:

Assume that the iterator is initialized to the beginning of the list: [1,2,3].

Call next() gets you 1, the first element in the list.
Now you call peek() and it returns 2, the next element. Calling next() after that still return 2. 
You call next() the final time and it returns 3, the last element. 
Calling hasNext() after that should return false.
Follow up: How would you extend your design to be generic and work with all types, not just integer?

   Hide Hint #1  
Think of "looking ahead". You want to cache the next element.
   Hide Hint #2  
Is one variable sufficient? Why or why not?
   Hide Hint #3  
Test your design with call order of peek() before next() vs next() before peek().
   Hide Hint #4  
For a clean implementation, check out Google's guava library source code.
*/

// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

using System.Collections.Generic;

class PeekingIterator
{
    // iterators refers to the first element of the array.
    IEnumerator<int> iterator;
    bool hasNext;
    public PeekingIterator(IEnumerator<int> iterator)
    {
        // initialize any member here.
        this.iterator = iterator;
        hasNext = true;
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return iterator.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        int ans = iterator.Current;
        hasNext = iterator.MoveNext();
        return ans;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return hasNext;
    }
}