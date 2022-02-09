using System;

namespace TDDPlayground
{
    public static class FizzBuzz
    {
        public static string[] Calculate(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                string[] result = new string[number];
                for (int i = 0; i < result.Length; i++)
                {
                    var element = i + 1;

                    if (element % 3 == 0)
                    {
                        result[i] = "Fizz";
                    }
                    else
                    {
                        result[i] = Convert.ToString(element);
                    }
                }
                return result;
            }
        }
    }
}