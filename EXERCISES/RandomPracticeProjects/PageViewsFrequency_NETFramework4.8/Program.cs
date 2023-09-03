using System;
using System.Collections.Generic;

namespace PageViewsFrequency_NETFramework4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pageViews1 = new List<int>() { 1, 1, 1, 1, 2, 2, 3, 4, 5, 5 };
            List<int> pageViews2 = new List<int>() { 1, 1, 2, 2, 3, 4, 5, 5 };

            Console.WriteLine(String.Join(" ", MaxPageViews(pageViews1)));
            Console.WriteLine("\n");
            Console.WriteLine(String.Join(" ", MaxPageViews(pageViews2)));

            /*  EXAMPLE OUTPUT:
               
                Key: 1, Value: 4
                Key: 2, Value: 2
                Key: 3, Value: 1
                Key: 4, Value: 1
                Key: 5, Value: 2
                1


                Key: 1, Value: 2
                Key: 2, Value: 2
                Key: 3, Value: 1
                Key: 4, Value: 1
                Key: 5, Value: 2
                1 2 5
             
             */

        }

        internal static List<int> MaxPageViews(List<int> pageViews)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            List<int> duplicateMaxPageFrequencies = new List<int>();

            int runningHighestFreq = 0;


            foreach (int page in pageViews)
            {
                if (frequencies.ContainsKey(page))
                {
                    runningHighestFreq = Math.Max(runningHighestFreq, frequencies[page]);
                    frequencies[page]++;

                    if (frequencies[page] > runningHighestFreq)
                    {
                        // completely empty out duplicate max page frequencies list if there is a new higher frequency
                        duplicateMaxPageFrequencies.Clear();

                        // update running highest frequency value
                        runningHighestFreq = frequencies[page];

                        // add page with new highest frequency to emptied list
                        duplicateMaxPageFrequencies.Add(page);
                    }
                    else if (frequencies[page] == runningHighestFreq)
                    {
                        // if there are multiple pages with the same max page view frequency, then add it to the duplicateMaxPageFrequencies list
                        duplicateMaxPageFrequencies.Add(page);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    frequencies.Add(page, 1);
                }
            }

            // Dictionary Printout
            foreach (KeyValuePair<int, int> freqPair in frequencies)
            {
                Console.WriteLine($"Key: {freqPair.Key}, Value: {freqPair.Value}");
            }

            return duplicateMaxPageFrequencies;
        }
    }
}