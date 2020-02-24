using System;

class Ping_pong
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        for (int i = 0; i<number; i++) 
        {
            if (((i % 3) == 0) && ((i % 5) ==0)) 
            {
                Console.WriteLine("Ping-Pong");
            }
            else if ((i % 3) == 0) 
            {
                Console.WriteLine("Ping");
            }
            else if ((i % 5) == 0) 
            {
                Console.WriteLine("Pong");
            } 
            else
            {
                Console.WriteLine(i);
            }
        }    
    }
};
