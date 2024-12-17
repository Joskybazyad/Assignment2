using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion

            #region Q2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter a number: ");
            //int numb = int.Parse(Console.ReadLine());
            //if (numb < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region Q3:Write a program that takes 3 integers from the user then prints the max element and the min element
            //int num1, num2, num3;
            //Console.WriteLine("Enter the first integer:");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second integer:");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third integer:");
            //num3 = int.Parse(Console.ReadLine());
            //int maxValue = Math.Max(num1, Math.Max(num2, num3));
            //int minValue = Math.Min(num1, Math.Min(num2, num3));
            //Console.WriteLine($"Maximum value: {maxValue}");
            //Console.WriteLine($"Minimum value: {minValue}");
            #endregion

            #region Q4:Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int number;
            //Console.WriteLine("Enter a number:");
            //number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}
            #endregion

            #region Q5: Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //char ch;
            //Console.WriteLine("Enter a character:");
            //ch = Char.Parse(Console.ReadLine());
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'|| ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' )
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}

            #endregion

            #region Q6:Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int number;
            //Console.WriteLine("Enter a number: ");
            //number = int .Parse(Console.ReadLine());
            //Console.WriteLine($"{number*1} {number * 2} {number * 3} {number * 4} {number * 5} {number * 6} {number * 7} {number * 8} {number * 9} {number * 10} {number * 11} {number * 12} ");
            #endregion

            #region Q7:Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int number;
            //Console.WriteLine("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q8:Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter base number :");
            //int baseNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter exponent number :");
            //int exponent = int.Parse(Console.ReadLine());
            //double result = Math.Pow(baseNumber, exponent);
            //Console.WriteLine(result);
            #endregion

            #region Q9:Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter the month number between 1 to 12: ");
            //int month = int.Parse(Console.ReadLine());
            //int days;
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}
            //Console.WriteLine("Days in Month: " + days);
            #endregion

            #region Q10: Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
            //Console.Write("Enter the time taken to complete the task: ");
            //double time = double.Parse(Console.ReadLine());
            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("Efficiency: Highly efficient");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("Efficiency: Increase your speed");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("Efficiency: You need training to improve speed");
            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("Efficiency: You are required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input: Time must be 2 hours or more.");
            //}
            #endregion

        }
    }
}
