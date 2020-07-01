/*
Given a list of airline tickets represented by pairs of departure and arrival airports [from, to], reconstruct the itinerary in order. All of the tickets belong to a man who departs from JFK. Thus, the itinerary must begin with JFK.

Note:

If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string. For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
All airports are represented by three capital letters (IATA code).
You may assume all tickets form at least one valid itinerary.
One must use all the tickets once and only once.
Example 1:

Input: [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]
Output: ["JFK", "MUC", "LHR", "SFO", "SJC"]
Example 2:

Input: [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"].
             But it is larger in lexical order.
*/

using System.Collections.Generic;

public class ReconstructItinerary
{
    public List<string> FindItinerary(List<List<string>> tickets)
    {
        Dictionary<string, List<string>> values = new Dictionary<string, List<string>>();
        List<string> result = new List<string>();
        foreach (var val in tickets)
        {
            if (values.ContainsKey(val[0]))
            {
                values[val[0]].Add(val[1]);
            }
            else
            {
                List<string> temp = new List<string>();
                temp.Add(val[1]);
                values.Add(val[0], temp);
            }
        }

        foreach (var val in values)
        {
            val.Value.Sort();
        }

        result.Add("JFK");
        string first = "JFK";

        while (values.Count != 0)
        {
            if (values.ContainsKey(first) && values[first].Count != 0)
            {
                string firstValue = values[first][0];
                if (values.ContainsKey(firstValue) && values[firstValue].Count != 0)
                {
                    values[first].RemoveAt(0);
                    result.Add(firstValue);
                    values.Remove(first);
                    first = firstValue;
                }
                else
                {
                    values.Remove(firstValue);
                }
            }
        }

        return result;
    }
}