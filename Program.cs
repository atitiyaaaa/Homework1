using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Number password : ");
        string pass = Console.ReadLine(); 
        Console.WriteLine("Agency : ");
        string agency = Console.ReadLine(); 

        if (pass.Length != 6)
        {
            Console.WriteLine("False");
        }
        else if (agency == "CIA")
        {
            if (pass[5] % 3 == 0
              && pass[4] != 1
              && pass[4] != 3
              && pass[4] != 5
              && pass[2] < 6
              && pass[2] != 8
              )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else if (agency == "FBI")
        {
            if (pass[0] >=4
              && pass[0] <=7
              && pass[3] % 2 == 0
              && pass[3] != 6
              && pass[1] % 2 == 1
              )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else if (agency == "NSA")
        {
            if (pass[5] == 1
              && pass[5] == 2
              && pass[5] == 3
              && pass[5] == 5
              && pass[5] == 6
              && pass[3] % 3 == 0
              && pass[3] % 2 != 0
              && pass.Contains("7")
              )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}