using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgramV4
{
    public class Functions
    {
        public string EvenOddDetector(int number) {
            if (number % 2 == 0) {
                return "Your Number is EVEN!";
            }
            else {
                return "Your Number is ODD!";
            }
        }

        public int[] RectangleProperties(int width, int length) {
            int perimeter = 2 * (width + length);
            int area = width * length;
            int[] result = [perimeter, area];
            return result;
        }

        public double[] CricleProperties(int radius)
        {
            double perimeter = radius * 2 * 3.14;
            double area = Math.Sqrt(radius) * 3.14;
            double[] result = [perimeter, area];
            return result;
        }

        public int[] switchNumbers(int number1, int nubmer2)
        {
            int[] allnumbers = [nubmer2, number1];
            return allnumbers;
        }

        public int[] FourMainOperators(int number1, int number2)
        {
            int total = number1 + number2;
            int minus = number1 - total;
            int multiply = number1 * number2;
            int divide = number1 / total;
            int[] result = [total, minus, multiply, divide];
            return result;
        }

        public double Average(double number1, int number2, int number3)
        {
            return (number1 + number2 + number3)/3;
        }
        
        public int Age(DateTime birthDay)
        {
            return DateTime.Now.Year - birthDay.Year;
        }

        public double TemperatureToKelvin(int  temperature)
        {
            return temperature + 273.15;
        }

        public string MonthName(int monthNumber)
        {
            string result = "";
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                switch (monthNumber)
                {
                    case 1:
                        result = "the month name is: January";
                        break;
                    case 2:
                        result = "the month name is: February";
                        break;
                    case 3:
                        result = "the month name is: March";
                        break;
                    case 4:
                        result = "the month name is: April";
                        break;
                    case 5:
                        result = "the month name is: May";
                        break;
                    case 6:
                        result = "the month name is: June";
                        break;
                    case 7:
                        result = "the month name is: July";
                        break;
                    case 8:
                        result = "the month name is: August";
                        break;
                    case 9:
                        result = "the month name is: September";
                        break;
                    case 10:
                        result = "the month name is: October";
                        break;
                    case 11:
                        result = "the month name is: November";
                        break;
                    case 12:
                        result = "the month name is: December";
                        break;
                }
            }
            else { result = "the month number you entered is not valid."; }
            return result;
        }

        public int[] SortedNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        public string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public string TextCuter(string text)
        {
            text = text.Trim();
            text = text.Substring(1, text.Length - 2);
            return text;
        }

        public string VowelsCuter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                //a, e, i, o, u
                if (text[i] != 'a' && text[i] != 'e' && text[i] != 'i' && text[i] != 'o' && text[i] != 'u')
                {
                }
                else
                {
                    text = text.Remove(i, 1);
                }
            }
            return text;
        }
    }
}
