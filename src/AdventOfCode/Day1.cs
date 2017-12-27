using System;

namespace AdventOfCode
{
    public class Day1
    {
        public static int InverseCaptcha(string input)
        {
            if (input.Length <= 1)
            {
                return 0;
            }
            int runningSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]))
                {
                    continue;
                }
                if (input[i] == input[((i + 1)% input.Length)])
                {
                    runningSum +=  (int)Char.GetNumericValue(input[i]);
                }
            }
            return runningSum;
        }
    }
}
