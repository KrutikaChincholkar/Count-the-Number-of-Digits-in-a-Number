
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int temp = num;

        if (temp == 0)
        {
            count = 1;
        }
        else
        {
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }
        }

        Console.WriteLine("Number of digits: " + count);
    }
}
