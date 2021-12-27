using System;

namespace cs02_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teorija

            Console.WriteLine("cs02_paskaita!");
            // Kintamasis (variable) - tai programos elementas turintis vardą,
            // galintis kisti ir įgyti skirtingas reikšmes.
            int number = 5;
            string name = "Vilmasntas";
            Console.WriteLine("Vardo ilgis:");
            Console.WriteLine(name.Length);
            number.CompareTo(number);

            //const int FIRST_NUMBER = 5; // <-- constantos nėra dažnai naudojamos

            // Operatoriai + - * / % ++ --
            // Loginiai && || ! ==
            // Relational == != > < >= <=

            //int x = 5;

            //bool averageGrade = x >= 5 ? "Number is bigger or equals to 5" : "Number is too small" ; // <-- Ternerio if'as

            #endregion

            //asignment1();
            //asignment2();
            //asignment3();
            //asignment4();
            //asignment5();
            //asignment6();
            //asignment7();
            //asignment8();
            //asignment9();
            //asignment10();
            //asignment11();
            //asignment12();
            asignment13();
            asignment14();

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
            //Swap values between two variables
            int a = 1;
            int b = 2;
            int c;

            c = b; // b = 2, o a = 1; <-- c kintamajam priskiriu b kintamojo reikšmę;
            b = a; // b = 2, o a = 2; <-- b kintamajam priskiriu a kintamojo reikšmę;
            a = c; // b = 1, o a = 2; <-- a kintamajam priskiriu c kintamojo reikšmę;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
        public static void asignment5()
        {
            Console.WriteLine("Input 2 numbers");           //<-- Consolė paduoda tekstą
            double d = double.Parse(Console.ReadLine());    //<-- Čia mes sakome, kad įvestis yra double tipo kintamojo
            double e = double.Parse(Console.ReadLine());    //<-- tas double.Parse nurodo kompiuteriui, kad jis defaultu priimamą stingą priimtų kaip double tipo kintamąjį;
            bool isEqual = d == e;                      // <-- čia mes kuriame bool tipo kintmąjį ir sakome ar lygūs kintamiej d ir e, jeigu taip bool bus true, jeigu ne false
            Console.WriteLine(isEqual);                 // išspausdiname bool reikšmę
        }

        public static void asignment6()
        {
            Console.WriteLine("Input 2 numbers");
            double f = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());
            Console.WriteLine(++f);                   // <-- mes sakome, prie kindamojo f pridedame 1;
            Console.WriteLine(--g);                   // <-- mes sakome, prie kindamojo g atimame 1;
        }

        public static void asignment7()
        {
            double borderA = double.Parse(Console.ReadLine());
            double borderB = double.Parse(Console.ReadLine());
            Console.WriteLine($"Perimetras yra: {borderA*2 + borderB*2}"); // <-- čia yra elementari matematika
            Console.WriteLine($"Plotas yra: {borderA * borderB}");
        }

        public static void asignment8()
        {
            Console.WriteLine("Enter a symbols, function checks if empty");
            string check = Console.ReadLine();
            var checkCheck = String.IsNullOrEmpty(check) ? "Empty" : "Not empty"; // <-- Čia mes naudojame metodą IsNullOrEmpty įvesčiai check;
            Console.WriteLine(checkCheck);
        }

        public static void asignment9()
        {
            Console.WriteLine("Enter a number, function checks if less than 0");
            double testTest = double.Parse(Console.ReadLine());
            var lessThan = testTest < 0 ? "input is less than 0" : "input is bigger than 0";
            Console.WriteLine(lessThan);
        }

        public static void asignment10()
        {
            Console.WriteLine($"Your name");
            string name = Console.ReadLine();       // <-- Pavyzdžiui čia mes nenaudojame parse, nes default įvestis yra string'as
            Console.WriteLine($"Your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{name}, {lastName}");
        }

        public static void asignment11()
        {
            Console.WriteLine($"String input please");
            string input = Console.ReadLine();
            Console.WriteLine($"String to lower-case:{input.ToLower()}");
            Console.WriteLine($"String to upper-case:{input.ToUpper()}");
        }

        public static void asignment12()
        {
            Console.WriteLine($"Digit input please");
            int input2 = int.Parse(Console.ReadLine());
            var checkInput2 = input2 % 3 == 0 ? "dalinasi iš 3" : "nesidalina iš 3";
            var checkInput3 = input2 % 7 == 0 ? "dalinasi iš 7" : "nesidalina iš 7";

            Console.WriteLine(checkInput2);
            Console.WriteLine(checkInput3);
        }

        public static void asignment13()
        {
            // Write a C# program to check if a string starts with a specified word.
            Console.WriteLine($"String input please (start w/ hello)");
            string input3 = Console.ReadLine();

            var checkInput3 = input3.Substring(0, 5) == "hello" ? "Prasideda su hello" : "neprasideda su hello";
            Console.WriteLine(checkInput3);
        }

        public static void asignment14()
        {
            // Write a program in C# Sharp to count the total number of words in a string.
            Console.WriteLine($"String input please");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3.Length);
        }
    }
}

