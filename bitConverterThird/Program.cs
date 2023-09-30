using System;

class Program
{
    static void DecimalToBit(int decimalNumber)
    {
        Console.Write("Binary: ");
        int[] binary = new int[32];
        int i = 0;
        while (decimalNumber > 0)
        {
            binary[i] = decimalNumber % 2;
            decimalNumber /= 2;
            i++;
        }

        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(binary[j]);
        }
        Console.WriteLine();
    }

    static void DecimalToHex(int decimalNumber)
    {
        Console.WriteLine($"Hexadecimal: {decimalNumber:X}");
    }

    static void DecimalToOctal(int decimalNumber)
    {
        Console.WriteLine($"Octal: {Convert.ToString(decimalNumber, 8)}");
    }

    static void Main()
    {
        int decimalNumber;
        char choice;

        do
        {
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out decimalNumber))
            {
                DecimalToBit(decimalNumber);
                DecimalToOctal(decimalNumber);
                DecimalToHex(decimalNumber);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.Write("Try again? (Y/N): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (char.ToUpper(choice) == 'Y');

        Console.WriteLine("Goodbye!");
    }
}