using System;
using System.Collections.Generic;
using System.Text;

namespace HaveFun
{
    public static class Problems
    {
        //1, 2, 2, 3, 2 =>1
        //1, 2, 3, 4 =>3
        public static int RoofTop(int[] arr)
        {
            int i = 0;

            while(i<arr.Length -1 
                && arr[i] < arr[i + 1])
            {
                i++;
            }

            return i;

        }

        //1 1 1 2 2 2 =>3
        //1 4 3 3 5 1 =>1
        public static int NumberofPpairsWithMaximumSum(int[] arr)
        {
            int maxValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            int result = 0;
            for (int m = 0; m < arr.Length; m++)
            {
                for (int n = m + 1 ; n < arr.Length; n++)
                {
                    if(arr[m] == arr[n] 
                        && arr[m]*2 > maxValue)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public static int FindFine(int date, int[] arrCarNumber, int[] arrFines)
        {
            int result = 0;
            for (int i = 0; i < arrCarNumber.Length; i++)
            {
                if(date%2 == 0 && arrCarNumber[i]%2 !=0)
                {
                    result += arrFines[i];
                }

                if(date%2!=0 && arrCarNumber[i]%2 == 0)
                {
                    result += arrFines[i];
                }
            }
            return result;
        }


        public static string RemoveCommonCharactersAndConcatenate(string firstStr, string secondStr)
        {
            if (string.IsNullOrEmpty(firstStr))
            {
                return "-1";
            }

            StringBuilder sb = new StringBuilder();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < firstStr.Length; i++)
            {
                if(!dic.ContainsKey(firstStr[i]))
                {
                    dic.Add(firstStr[i],1);
                }
            }

            for (int j = 0; j < secondStr.Length; j++)
            {
                if (dic.ContainsKey(secondStr[j]))
                {
                    dic.Remove(secondStr[j]);
                    dic.Add(secondStr[j], 0);
                }
                else
                {
                    dic.Add(secondStr[j], 1);
                }
            }

            foreach (var c in dic)
            {
                if (c.Value != 0)
                {
                    sb.Append(c.Key);

                }
            }

            return sb.ToString();
        }

        //1A0B1 => 1
        public static int BooleanStringValue(string input)
        {
            int i = 0;
            int tempValue = int.Parse(input[0].ToString());
            while( i + 2 < input.Length)
            {
                char op = input[i + 1];
                int secondValue = int.Parse(input[i + 2].ToString());

                if(op == 'A')
                {
                    tempValue = tempValue & secondValue;
                }else if(op == 'B')
                {
                    tempValue = tempValue | secondValue;
                }else if(op == 'C')
                {
                    tempValue = tempValue ^ secondValue;
                }
                else
                {
                    throw new NotImplementedException("not support");
                }
                i += 2;
            }
            return tempValue;
        }


        public static string SumOfTwoLargeNumbers(int bigInt1, int bigInt2)
        {
            string bigNumberStr1 = bigInt1.ToString();
            string bigNumberStr2 = bigInt2.ToString();
            string result = string.Empty;

            Stack<int> sb = new Stack<int>();
          
            int i = bigNumberStr1.Length - 1;
            int j = bigNumberStr2.Length - 1;

            bool increased = false;
            while (i >= 0 || j>=0)
            {
                int sum = 0;

                if (i < 0)
                {
                    sum = int.Parse(bigNumberStr2[j].ToString());
                }
                else if (j < 0)
                {
                    sum = int.Parse(bigNumberStr1[i].ToString());
                }
                else
                {
                    sum = int.Parse(bigNumberStr1[i].ToString()) + int.Parse(bigNumberStr2[j].ToString());
                    if (increased)
                    {
                        sum = sum + 1;
                    }
                    if (sum > 9)
                    {
                        sum = sum - 10;
                        increased = true;
                    }
                    else
                    {
                        increased = false;
                    }
                }

                sb.Push(sum);
                i--;
                j--;
            }

            int value;

            while(sb.TryPop(out value))
            {
                result += value.ToString();
            }

            return result;
        }

        //asdf as => as
        public static int Substring(string firstStr, string secondStr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while(i>=0 
                && i <= firstStr.Length - secondStr.Length)
            {
                k = i;
                while(j >=0 
                    && j < secondStr.Length
                    && firstStr[k] == secondStr[j])
                {
                    k++;
                    j++;
                }
                if (j == secondStr.Length)
                {
                    return i;
                }

                i++;
            }
            return -1;

        }

    }
}
