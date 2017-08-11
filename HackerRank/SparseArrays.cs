using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class SparseArrays
    {
        static void Main(string[] args)
        {
            int numOfStrings = Convert.ToInt16(Console.ReadLine());
            List<string> inputStrings = new List<string>();
            for (int i = 0; i< numOfStrings; i++)
            {
                inputStrings.Add(Console.ReadLine());
            }
            int numOfQueryStrings = Convert.ToInt16(Console.ReadLine());
            List<string> queryStrings = new List<string>();
            for (int i = 0; i < numOfQueryStrings; i++)
            {
                queryStrings.Add(Console.ReadLine());
            }
            List<string> matchElements = new List<string>();
            foreach (string queryString in queryStrings)
            {
                matchElements = inputStrings.Where(inp => inp == queryString).ToList();
                Console.WriteLine(matchElements.Count);
            }
        }
    }
}
