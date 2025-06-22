using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Practice_Problems
{
    internal class Practice
    {
        public static string ReverseString(string str)
        {
            string temp = "";
            char[] chars = str.ToCharArray();
            for(int i = chars.Length-1; i>=0; i--)
            {
                temp += chars[i];
            }
            return temp;
        }

        public static int[] FindDuplicates(int[] arr)
        {
            bool[] visited = new bool[arr.Length];
            int[] tempDuplicates = new int[arr.Length];
            int duplicateCounts=0;
            
            for(int i=0; i<arr.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }
                int count = 1;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                if(count > 1)
                {
                    bool alreadyAdded = false;
                    for(int k =0; k< duplicateCounts; k++)
                    {
                        if (arr[k] == arr[i])
                        {
                            alreadyAdded = true;
                            break;
                        }
                    }

                    if (!alreadyAdded)
                    {
                        tempDuplicates[duplicateCounts] = arr[i];
                        duplicateCounts++;
                    }

                    


                    Console.WriteLine($"{arr[i]} is repeated {count} times");
                }
            }

            //store duplicates in result array
            int[] resultArr = new int[duplicateCounts];
            for (int i=0; i<duplicateCounts; i++)
            {
                resultArr[i] = tempDuplicates[i];
            }

            return resultArr;
        }

        public static void Test()
        {
            string s = "hello";
            int[] arr = { 1, 2, 2, 3, 44, 44, 5 ,5 };


            Console.WriteLine($"Duplicates are {String.Join(',',FindDuplicates(arr))}");
            Console.WriteLine($"Reverse of {s} is {ReverseString(s)}");
        }
    }
}
