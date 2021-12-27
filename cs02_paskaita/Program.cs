using System;

namespace cs02_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs02_paskaita!");
            // Kintamasis (variable) - tai programos elementas turintis vardą,
            // galintis kisti ir įgyti skirtingas reikšmes.
            int number = 5;
            string name = "Vilmasntas";
            Console.WriteLine(name.Length);
            number.CompareTo(number);

            //asignment1();
            asignment2();
            asignment3();

            const int FIRST_NUMBER = 5;

        }

        public static void asignment1()
        {
            Console.WriteLine("Input 2 numbers");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");

            Console.WriteLine("Press ENTER to CONTINUE");
            Console.ReadLine();
        }

        public static void asignment2()
        {
            Console.WriteLine("Input 3 numbers");

            double thirdNumber = double.Parse(Console.ReadLine());
            double forthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdNumber} + {forthNumber} + {fifthNumber} / 3 = {(thirdNumber + forthNumber + fifthNumber) / 3}");
            Console.WriteLine("Press ENTER to CONTINUE");
            Console.ReadLine();
        }

        public static void asignment3()
        {
            Console.WriteLine("Enter the name of school: ");
            string schoolName = Console.ReadLine();

            Console.WriteLine("Enter the name of course: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter student count: ");
            int studentCount = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today.Date;

            DateTime courseStartDate = today.AddDays(-7);
            DateTime courseEndDate = courseStartDate.AddMonths(8);

            Console.WriteLine($"School name is {schoolName}, course name is {courseName}, student count is: {studentCount}, date: {today}");
            Console.WriteLine();

            Console.WriteLine((courseEndDate - courseStartDate).TotalDays);

            Console.WriteLine("Press ENTER to CONTINUE");
            Console.ReadLine();
        }

        public static void asignment4()
        {

        }
    }
}

