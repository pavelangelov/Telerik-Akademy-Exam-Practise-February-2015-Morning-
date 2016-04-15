namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputNumbers = new List<string>();
            while (input != "END")
            {
                inputNumbers.Add(input);
                input = Console.ReadLine();
            }
            if (inputNumbers.Count <= 10)
            {
                BigInteger result = 1;
                for (int i = 1; i < inputNumbers.Count; i += 2)
                {
                    string num = inputNumbers[i];
                    ulong product = 1U;
                    for (int j = 0; j < num.Length; j++)
                    {
                        ulong currentNum = (ulong)(num[j] - '0');
                        if (currentNum != 0)
                        {
                            product *= currentNum;
                        }
                    }
                    result *= product;
                }

                Console.WriteLine(result);
            }
            else
            {
                BigInteger productOfFirstTen = 1;
                BigInteger productOfTheRest = 1;
                for (int i = 1; i < inputNumbers.Count; i += 2)
                {
                    string num = inputNumbers[i];
                    ulong product = 1U;
                    for (int j = 0; j < num.Length; j++)
                    {
                        ulong currentNum = (ulong)(num[j] - '0');
                        if (currentNum != 0)
                        {
                            product *= currentNum;
                        }
                    }
                    if (i < 10)
                    {
                        productOfFirstTen *= product;
                    }
                    else
                    {
                        productOfTheRest *= product;
                    }
                }
                Console.WriteLine(productOfFirstTen);
                Console.WriteLine(productOfTheRest);
            }

        }
    }
}
