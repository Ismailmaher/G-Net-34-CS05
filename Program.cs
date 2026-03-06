using System.Security.Cryptography;
using System.Threading.Channels;

namespace G_Net_34_CS05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //int dayNumber = 0;
            //bool isValidInput = false;

            //do
            //{
            //    Console.WriteLine("Enter a day number (1-7): \n");
            //    dayNumber = int.Parse(Console.ReadLine());
            //    if (dayNumber >= 1 && dayNumber <= 7)
            //    {
            //        DayOfWeek selectDay = (DayOfWeek)dayNumber;
            //        Console.WriteLine($"Day:{selectDay}");

            //        switch (selectDay)
            //        {
            //            case DayOfWeek.friday:
            //            case DayOfWeek.satarday:
            //                Console.WriteLine($"It is a Weekend");
            //                break;
            //            default:
            //                Console.WriteLine($"It is a workday");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Invalid day number. Please enter a number between 1 and 7.\n");
            //    }
            //} while (!isValidInput);   
            #endregion

            #region  Question 2
            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //int max = numbers[0];
            //int min = numbers[0];
            //for (int i = 0; i < size; i++)
            //{
            //    sum += numbers[i];

            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if(numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //double average = (double)sum / size;

            //Console.WriteLine($"\nSum      = {sum}");
            //Console.WriteLine($"Average  = {average}");
            //Console.WriteLine($"Max      = {max}");
            //Console.WriteLine($"Min      = {min}");
            //Console.Write("Reverse  = ");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + (i == 0 ? "" : ", "));
            //}
            //Console.WriteLine();
            #endregion

            #region Question 2_part_2_array
            //double[,] grades = new double[3, 4];
            //double totalSum = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"  Subject {j + 1}: ");
            //        grades[i, j] = double.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("-------------------------");
            //}
            //Console.WriteLine("\n--- Results ---");
            //for (int i = 0; i < 3; i++)
            //{
            //    double studentSum = 0;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        studentSum += grades[i, j];
            //    }

            //    double studentAverage = studentSum / 4;
            //    totalSum += studentSum; 

            //    Console.WriteLine($"Student {i + 1} Average: {studentAverage}");
            //}
            //double classAverage = totalSum / (3 * 4);
            //Console.WriteLine($"\nOverall Class Average: {classAverage}");

            #endregion

        }
    }
}
