namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Amar Al-failakawi Task_Basics");

            int gpa = 3;
            Console.WriteLine(gpa);

            double gpaA = 3.8;
            Console.WriteLine(gpaA);

            string gpaB = "3.9";
            Console.WriteLine(gpaB);    

            bool isGpaE = true;
            Console.WriteLine(isGpaE);

            int number = 4; decimal result = Convert.ToDecimal(number);
            Console.WriteLine(result);

            string studentName = "Yara";
            Console.WriteLine(studentName);

            int studentGrade = 90;
            Console.WriteLine(studentGrade);

            string studentFavoriteSubject = "Chem"; 
            Console.WriteLine(studentFavoriteSubject);

            char[] studentGrades = new char[] { 'A'};
            Console.WriteLine(studentGrades);

            int length = 12;
            int width = 12; 
            int area = length * width;
            Console.WriteLine(area);
        }
    }
}
