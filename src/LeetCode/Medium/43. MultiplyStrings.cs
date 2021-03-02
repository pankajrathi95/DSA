/*
https://leetcode.com/problems/multiply-strings/
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.

 

Example 1:

Input: num1 = "2", num2 = "3"
Output: "6"
Example 2:

Input: num1 = "123", num2 = "456"
Output: "56088"
 

Constraints:

1 <= num1.length, num2.length <= 200
num1 and num2 consist of digits only.
Both num1 and num2 do not contain any leading zero, except the number 0 itself.
*/

using System.Text;

public class MultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        if (num1.Equals("0") || num2.Equals("0"))
        {
            return "0";
        }

        int[] result = new int[num1.Length + num2.Length];
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int sum = mul + result[i + j + 1];

                result[i + j + 1] = sum % 10;
                result[i + j] += sum / 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < result.Length; i++)
        {
            if (i == 0 && result[i] == 0)
            {
                continue;
            }

            sb.Append(result[i]);
        }

        return sb.ToString();
    }
}
