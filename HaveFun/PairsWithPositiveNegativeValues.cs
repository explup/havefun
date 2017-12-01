using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HaveFun
{
    public static class PairsWithPositiveNegativeValues
    {
        public static void Print()
        {
            string testCasesNumber = Console.ReadLine();
            int[][] result = new int[int.Parse(testCasesNumber)][];

            for (int i = 0; i < int.Parse(testCasesNumber); i++)
            {
                string arrayLength = Console.ReadLine();
                int[] input = new int[int.Parse(arrayLength)];

                string arrayContent = Console.ReadLine();
                string[] arrayStr = arrayContent.Split(' ');
                for (int j = 0; j < arrayStr.Length; j++)
                {
                    input[j] = int.Parse(arrayStr[j]);
                    result[i] = Generate(input);
                }
            }

            for (int m = 0; m < result.Length; m++)
            {
                string output = string.Empty;
                int[] array = result[m];
                for (int n = 0; n < array.Length; n++)
                {
                    output = output + array[n] + " ";
                }
                Console.WriteLine(output);
            }
        }
        public static int[] Generate(int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            IList<int> positiveValues = new List<int>();
            IList<int> negativeValues = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positiveValues.Add(arr[i]);                  
                }
                else
                {
                    negativeValues.Add(arr[i]);
                }
            }

            positiveValues = positiveValues.OrderBy(p => p).ToList(); ;

            int[] result = new int[arr.Length];
            int currentIndex = 0;
            int j = 0;
            while(j < positiveValues.Count
                &&currentIndex < arr.Length - 1)
            {
                int pValue = positiveValues[j];
                if (negativeValues.Contains(-pValue))
                {
                    result[currentIndex] = -pValue;
                    result[currentIndex + 1] = pValue;
                    currentIndex = currentIndex + 2;
                }
                j++;
            }
            return result;
        } 
    }
}
