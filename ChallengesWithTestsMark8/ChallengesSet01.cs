using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2) //bool needs a return which means it it needs an if and else
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return (minuend - subtrahend);         //double needs a return and subtract whats 
        }                                          //whats in parentheses                     

        public int Add(int number1, int number2)
        {                                          //needs a return because its an int add      
            return (number1 + number2);            // number 1 and 2
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)     // smallest number needs return
            {
                return number1;    
            }
            else 
            { 
                return number2; 
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (string.IsNullOrEmpty(nameOfPerson)) //if string is empty we will return "hello!"
            {
                return "Hello!";
            }
            else 
            {
                return ($"Hello, {nameOfPerson}!");
            }
        }   


        public string GetHey()
        {

            return ("HEY!");
        }
    }
}
