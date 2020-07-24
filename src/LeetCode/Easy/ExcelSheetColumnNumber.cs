/*
https://leetcode.com/problems/excel-sheet-column-number/
*/

using System;

public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string s)
    {
        int sum = 0, power = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sum += (int)Math.Pow(26, power++) * (s[i] - 64);
        }

        return sum;
    }
}