/*

You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

Example:

Given n = 5, and version = 4 is the first bad version.

call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true

Then 4 is the first bad version. 

*/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class FirstBadVersion
{
    int firstBadVersion = 1;
    public int FindFirstBadVersion(int n)
    {
        firstBadVersion = n;
        return BadVersion(1, n);
    }

    private int BadVersion(int first, int last)
    {
        if (first >= last)
        {
            return firstBadVersion;
        }

        long mid = ((long)first + last) / 2;
        int middle = (int)mid;
        if (IsBadVersion(middle))
        {
            firstBadVersion = middle;
            return BadVersion(first, middle);
        }
        else
        {
            return BadVersion(middle + 1, last);
        }
    }
}