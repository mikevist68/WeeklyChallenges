using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0) 
            {
                return 0;
            }
           
            return numbers.Min() + numbers.Max();
        }   

            




        

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else 
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];  
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }
            var evensum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensum += numbers[i];
                }
            }

            return evensum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;

            }
            else 
            {
                return number / 2;  
            }
        }   
    }
}
