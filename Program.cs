using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace GradeCalculator
{
    class GradeInputOutput
    {
    static void Main(string[] args)
    {
        Console.WriteLine("------Student's Letter Grade Calculator------");

        string Grade = "";
        string conclusion = "Passed";
        
        Console.WriteLine("Enter the Student's First Name: ");
        string? studentFirstName = Console.ReadLine();

        Console.WriteLine("Enter the Student's Last Name: ");
        string? studentLastName = Console.ReadLine();

        Console.WriteLine("Enter the Student's ID Number: ");
        string? studentID = Console.ReadLine();

        Console.WriteLine("Enter the Midterm Exam Score: ");
        double midTerm = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Final Exam Score: ");
        double final = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Discontinuity Percentage: ");
        int discontinuity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the disciplinary status (true or false)");
        bool disciplinary = Convert.ToBoolean(Console.ReadLine());    
        //Grade Calculation begins.
        double average = (midTerm * 0.4)+(final*0.6);
        if (average <= 100 && average >= 90)
            {
                Grade = "AA";
            }
            else if (average <= 89 && average >= 85 )
            {
                Grade = "BA";
            }
            else if (average <= 84 && average >= 80 )
            {
                Grade = "BB";
            }
            else if (average <= 79 && average >= 75 )
            {
                Grade = "CB";
            }
            else if (average <= 74 && average >= 70 )
            {
                Grade = "CC";
            }
            else if (average <=69 && average >=60)
            {
                Grade = "DC";
            }
            else if (average <= 59 && average >= 50 )
            {
                Grade = "DD";
            }
            else if (average < 0 || average > 100 || midTerm > 100 || midTerm < 0 || final > 100 || final < 0 )
            {
                Grade = "ERROR";
            }
            else
            {
                Grade = "FF";
            }
            if (discontinuity > 30 || Grade == "FF" || disciplinary == true )
            {
                conclusion = "Failed";
            }
            else {}
            if (Grade == "ERROR")
            {
                throw new Exception("ERROR: Enter valid numbers for grading (0-100)");
            }
            else{
            Console.WriteLine($"\nStudent's Name: {studentFirstName} {studentLastName} School ID: {studentID} Grade: {Grade} Status: {conclusion} ");
            }
    }
 }


}