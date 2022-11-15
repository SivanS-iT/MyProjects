
using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! \n \n");

        Console.WriteLine("Set the reference number:");
        int refer = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Set the ordinal number of the alphabet that you want to be changed into character:");
        int res = Convert.ToInt32(Console.ReadLine());



        while (true)
        {

            Console.WriteLine(GetCharFromNumber(res, refer));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Set new number to character:");
            res = Convert.ToInt32(Console.ReadLine());


        }



    }

    public static string GetCharFromNumber(int number, int referenceNumber)
    {
        char[] az = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
        int converter = 0;
        char resul;

        
        int rech = referenceNumber % 26;

        converter = Math.Abs(number - rech) % 26;
        resul = az[converter];

        return resul.ToString();
    }
}