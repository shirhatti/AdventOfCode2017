using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day2
    {
        public static List<int> LineToList(String line)
        {
            string[] numbers = line.Split(new Char [] { ' ', '\t'});
            var listOfNumbers = new List<int>();
            foreach (var number in numbers)
            {
                int parsedValue = 0;
                if(!Int32.TryParse(number, out parsedValue))
                {
                    throw new ArgumentException();
                }
                listOfNumbers.Add(parsedValue);
            }
            return listOfNumbers;
        }

        public static int MaxMinusMin(List<int> list)
        {
            int min = list.First();
            int max = list.First();
            foreach (var number in list)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            return max - min;
        }

        public static int PerfectDivisors(List<int> list)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < list.Count; i++)
            {
                for (j = 0; j < list.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (list[i] == 0)
                    {
                        continue;
                    }
                    if ( list[j]%list[i] == 0 )
                    {
                        return list[j]/list[i];
                    }
                }
            }
            throw new ArgumentException();
        }

        public static int ComputeCheckSum(string input, Func<List<int>, int> listOperation)
        {
            int checksum = 0;
            string[] lines = input.Split(new Char [] { '\n'});
            foreach(var line in lines)
            {
                var list = LineToList(line);
                checksum += listOperation(list);
            }
            return checksum;
        }
    }
}