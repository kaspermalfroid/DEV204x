using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();
            PrintStudentDetails("Tim", "Lee", "01-02-2002");
        }
        static void GetStudentInfo()
        {
	        Console.WriteLine("Enter the student's first name: ");
	        string firstName = Console.ReadLine();
	        Console.WriteLine("Enter the student's last name");
	        string lastName = Console.ReadLine();
	        Console.WriteLine("Enter the student's date of birth");
	        DateTime birthDate = DateTime.Parse(Console.ReadLine());
            bool validBirthDate = false;
            validBirthDate = ValidateStudentBirthday(birthDate);
        }
        static void GetTeacherInfo()
        {
	        Console.WriteLine("Enter the teacher's first name: ");
	        string firstName = Console.ReadLine();
	        Console.WriteLine("Enter the teacher's last name");
	        string lastName = Console.ReadLine();
	        Console.WriteLine("Enter the teacher's date of birth");
	        string birthDateString = Console.ReadLine();
	        DateTime birthDate = DateTime.Parse(birthDateString);
        }
        static void GetCourseInfo()
        {
	        Console.WriteLine("Enter the name of the course: ");
	        string courseName = Console.ReadLine();
	        Console.WriteLine("Enter the amount of credits");
	        int credits = Int32.Parse(Console.ReadLine());
        }
        static void GetProgramInfo()
        {
	        Console.WriteLine("Enter the name of the program: ");
	        string programName = Console.ReadLine();
	        Console.WriteLine("Enter the amount of semesters");
	        int semesters = Int32.Parse(Console.ReadLine());
        }
        static void GetDegreeInfo()
        {
	        Console.WriteLine("Enter the name of the degree: ");
	        string degreeName = Console.ReadLine();
	        Console.WriteLine("Enter the name of the university");
	        string universityName = Console.ReadLine();
        }
        static bool ValidateStudentBirthday(DateTime birthDate)
        {
	        try
	        {
                if ((DateTime.Now.Year - birthDate.Year) < 18)
                {
                    throw new ArgumentOutOfRangeException("age", "All students must be minimum 18-years old.");
                }
                else
                {
                    return true;
                }
	        }
	        catch (FormatException fEx)
	        {
		        Console.WriteLine("Wrong date format!");
	        }
	        catch (ArgumentNullException argNullEx)
	        {
		        Console.WriteLine("Empty date string!");
	        }
	        catch (ArgumentOutOfRangeException outOfRangeEx)
	        {
		        Console.WriteLine(outOfRangeEx.Message);
	        }
            return false;
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
	        Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        static void PrintTeacherDetails(string first, string last, string birthday)
        {
	        Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        static void PrintCourseDetails(string course, int credits)
        {
	        Console.WriteLine("The course {0} has {1} credits", course, credits);
        }
        static void PrintProgramDetails(string program, int semesters)
        {
	        Console.WriteLine("The program \"{0}\" has {1} semesters", program, semesters);
        }
        static void PrintDegreeDetails(string degree, string university)
        {
	        Console.WriteLine("The degree {0} was given by {1}", degree, university);
        }
    }
}
