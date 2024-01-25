namespace myProgramV4
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Functions myFunc = new Functions();

            Console.WriteLine("enter a nubmer to detect if it is odd or even:");
            int numberOddEven = Convert.ToInt16((Console.ReadLine()));
            Console.WriteLine(myFunc.EvenOddDetector(numberOddEven));
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("enter two number to calculate the perimeter and the area of a Rectangle that size.");
            Console.Write("enter the width:");
            int width = Convert.ToInt16((Console.ReadLine()));
            Console.Write("enter the length:");
            int length = Convert.ToInt16((Console.ReadLine()));
            int[] q2result = myFunc.RectangleProperties(width, length);
            Console.WriteLine($"the perimeter is: {q2result[0]}\nthe area is: {q2result[1]}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.Write("enter a number as the radius of a circle to calculate its properties:");
            int radius = Convert.ToInt16((Console.ReadLine()));
            double[] q3result = myFunc.CricleProperties(radius);
            Console.WriteLine($"the perimeter of the circle is: {q3result[0]}\nthe area of the circle is: {q3result[1]}");
            Console.WriteLine("Note: \"pi\" in this case was calculated as \"3.14\"");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("enter to number to switch their places.");
            Console.Write("enter Number one:");
            int switchNumber1 = Convert.ToInt16((Console.ReadLine()));
            Console.Write("enter Nubmer two:");
            int switchNumber2 = Convert.ToInt16((Console.ReadLine()));
            int[] q4result = myFunc.switchNumbers(switchNumber1, switchNumber2);
            Console.WriteLine($"Your number now are: {q4result[0]} {q4result[1]}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("enter two nubmers for me so I can do the 4 main math operations on them.");
            Console.Write("enter Number one:");
            int operatorNumber1 = Convert.ToInt16((Console.ReadLine()));
            Console.Write("enter Number two:");
            int operatorNumber2 = Convert.ToInt16((Console.ReadLine()));
            int[] q5result = myFunc.FourMainOperators(operatorNumber1, operatorNumber2);
            Console.WriteLine($"the total of them: {q5result[0]}" +
                $"\nthe minus: {q5result[1]}" +
                $"\nthe multiply: {q5result[2]}" +
                $"\nthe devide: {q5result[3]}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("enter three numbers so i can show you the average of them.");
            Console.Write("enter number 1: ");
            double averageNumber1 = Convert.ToInt16((Console.ReadLine()));
            Console.Write("enter number 2: ");
            int averageNumber2 = Convert.ToInt16((Console.ReadLine()));
            Console.Write("enter number 3: ");
            int averageNumber3 = Convert.ToInt16((Console.ReadLine()));
            Console.WriteLine($"the aswer is: {myFunc.Average(averageNumber1, averageNumber2, averageNumber3)}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.Write("enter your birth day so i can calculate your age in the format of (dd/MM/YYYY) like (01/01/2001)");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(myFunc.Age(birthDay));
            Console.WriteLine("------------------------------------------------------------------");

            Console.Write("give me a centigrade temperature and I will give it back as kelvin: ");
            int temperature = Convert.ToInt16((Console.ReadLine()));
            Console.WriteLine($"Temperature in Kelvin is: {myFunc.TemperatureToKelvin(temperature)}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.Write("enter a month number to get the month name: ");
            int monthNumber = Convert.ToInt16((Console.ReadLine()));
            Console.WriteLine(myFunc.MonthName(monthNumber));
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("give me three numbers and I will sort them for you.");
            int[] numberSort = new int[3]; 
            Console.Write("enter number 1: ");
            numberSort[0] = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter number 2: ");
            numberSort[1] = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter number 3: ");
            numberSort[2] = Convert.ToInt16(Console.ReadLine());
            numberSort = myFunc.SortedNumbers(numberSort);
            Console.WriteLine($"the sorted list is: \n{numberSort[0]}\n{numberSort[1]}\n{numberSort[2]}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("enter your name.");
            Console.Write("enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"your full name is: {myFunc.FullName(firstName, lastName)}");
            Console.WriteLine("------------------------------------------------------------------");

            
            Console.WriteLine("write a Text and I will cut the first and last letter of it:");
            string text = Console.ReadLine();
            Console.WriteLine($"answer is: {myFunc.TextCuter(text)}");
            Console.WriteLine("------------------------------------------------------------------");


            Console.WriteLine("enter a text to remove all Vowels in that text:");
            string textVowelsCuter = Console.ReadLine();
            Console.WriteLine($"your new text is:\n{myFunc.VowelsCuter(textVowelsCuter)}");


        }
    }
}