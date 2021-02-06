using System;
using System.Collections.Generic;

public class SimplifyPath
{
    //Without Split() Method
    public string SimplifyPathWithoutSplitMethod(string path)
    {
        LinkedList<string> list = new LinkedList<string>();
        int start = 0, end = 0;
        while (end < path.Length)
        {
            if (path[end] == '/' && start != end)
            {
                string command = path.Substring(start + 1, end - start - 1);
                if (command.Equals(".."))
                {
                    if (list.Count != 0) list.RemoveLast();
                    start = end;
                }
                else if (command.Equals("."))
                {
                    start = end;
                }
                else
                {
                    list.AddLast(command);
                    start = end;
                }
            }

            if (start == end)
            {
                while (end + 1 < path.Length && path[end + 1] == '/')
                {
                    start++;
                    end++;
                }
            }

            end++;
        }

        if (start != end)
        {
            string command = path.Substring(start + 1, end - start - 1);
            if (command.Equals(".."))
            {
                if (list.Count != 0) list.RemoveLast();
            }
            else if (!command.Equals("."))
            {
                list.AddLast(command);
            }
        }

        string result = "/";
        foreach (var l in list)
        {
            result += l + "/";
        }

        result = result.TrimEnd('/');
        return result.Length == 0 ? "/" : result;
    }

    //With Split() Method
    public string SimplifyPathWithSplitMethod(string path)
    {
        LinkedList<string> list = new LinkedList<string>();
        string[] strs = path.Split("/");
        foreach (var str in strs)
        {
            if (str.Equals(".."))
            {
                if (list.Count != 0) list.RemoveLast();
            }
            else if (!str.Equals(".") && !str.Equals(""))
            {
                list.AddLast(str);
            }
        }

        string result = "/";
        foreach (var l in list)
        {
            result += l + "/";
        }

        result = result.TrimEnd('/');
        return result.Length == 0 ? "/" : result;
    }
}