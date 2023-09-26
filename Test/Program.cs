namespace Test
{
    using System;
        class Program
    {
        // Функція для переведення числа в двійкову систему
        static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        // Функція для переведення числа в вісімкову систему
        static string DecimalToOctal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 8);
        }

        // Функція для переведення числа в шістнадцяткову систему
        static string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a decimal number: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                string binaryNumber = DecimalToBinary(decimalNumber);
                string octalNumber = DecimalToOctal(decimalNumber);
                string hexadecimalNumber = DecimalToHexadecimal(decimalNumber);

                Console.WriteLine($"Binary: {binaryNumber}");
                Console.WriteLine($"Octal: {octalNumber}");
                Console.WriteLine($"Hexadecimal: {hexadecimalNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid decimal number");
            }
        }
    }
}