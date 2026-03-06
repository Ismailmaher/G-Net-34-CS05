using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Part 3: Functions (Methods)Q1 Basic Calculator Functions
            //static double Add(double a, double b)
            //{
            //    return a + b;
            //}   
            //static double Subtract(double a, double b)
            //{
            //    return a - b;
            //}
            //static double Multiply(double a, double b)
            //{
            //    return a * b;
            //}
            //static double Divide(double a, double b)
            //{
            //    if (b == 0)
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //        return double.NaN; 
            //    }
            //    return a / b;
            //}
            //bool continueCalculations = true;
            //do {    
            //Console.WriteLine($"Enter the First Number: ");
            //double num1=double.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter the Second Number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter operation (+, -, *, /): ");
            //char op = Console.ReadLine()[0];
            //double result = 0;
            //bool valid = true;

            //    switch (op)
            //    {
            //        case '+':
            //            result = Add(num1, num2);
            //            break;
            //        case '-':
            //            result = Subtract(num1, num2);
            //            break;
            //        case '*':
            //            result = Multiply(num1, num2);
            //            break;
            //        case '/':
            //            result = Divide(num1, num2);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operation.");
            //            valid = false;
            //            break;
            //    }
            //    if (valid)
            //    {
            //        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            //    }
            //    Console.Write("\nDo you want to perform another calculation? (y/n): ");
            //    continueCalculations = Console.ReadLine().ToLower() == "y";
            //} while (continueCalculations);




            #endregion

            #region Part 3: Functions (Methods)Q2 : Circle Calculator with out
            //static void CalculateCircle(double radius, out double area, out double circumference)
            //{
            //    area = Math.PI * radius * radius;
            //    circumference = 2 * Math.PI * radius;
            //}
            //Console.Write("Enter the radius of the circle: ");
            //if (double.TryParse(Console.ReadLine(), out double r))
            //{ 
            //    CalculateCircle(r, out double area, out double circum);


            //    Console.WriteLine($"Results for Radius {r}:");
            //    Console.WriteLine($"Area          : {area}");
            //    Console.WriteLine($"Circumference : {circum}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a numeric value.");
            //}
            #endregion

            #region Create a new Console Application project
        //    static Grade GetGrade(int score)
        //    {
        //        if (score >= 90) return Grade.A;
        //        if (score >= 80) return Grade.B;
        //        if (score >= 70) return Grade.C;
        //        if (score >= 60) return Grade.D;
        //        return Grade.F;
        //    }

        //    static double CalculateAverage(int[] scores)
        //    {
        //        int sum = 0;
        //        foreach (int score in scores)
        //        {
        //            sum += score;
        //        }

        //        return (double)sum / scores.Length;
        //    }
        //    static void GetMinMax(int[] scores, out int min, out int max)
        //    {
        //        min = scores[0];
        //        max = scores[0];
        //        foreach (int score in scores)
        //        {
        //            if (score < min) min = score;
        //            if (score > max) max = score;
        //        }
        //    }
         
        //    int[] studentScores = new int[5];

         
        //    Console.WriteLine("--- Enter Student Scores ---");
        //    for (int i = 0; i < studentScores.Length; i++)
        //    {
        //        Console.Write($"Enter score for student {i + 1}: ");
        //        studentScores[i] = int.Parse(Console.ReadLine());
        //    }

            
        //    Console.WriteLine("\n--- Report ---");
        //    for (int i = 0; i < studentScores.Length; i++)
        //    {
        //        Grade studentGrade = GetGrade(studentScores[i]);
        //        Console.WriteLine($"Student {i + 1}: Score = {studentScores[i]}, Grade = {studentGrade}");
        //    }

           
        //    double avg = CalculateAverage(studentScores);
        //    GetMinMax(studentScores, out int minScore, out int maxScore);

        //    Console.WriteLine("\n--- Class Statistics ---");
        //    Console.WriteLine($"Class Average : {avg}");
        //    Console.WriteLine($"Highest Score : {minScore}");
        //    Console.WriteLine($"lowest Score: {maxScore}");

        //    Console.WriteLine("\nPress any key to exit...");
        //    Console.ReadKey();
        //}
            #endregion

    }
    }
