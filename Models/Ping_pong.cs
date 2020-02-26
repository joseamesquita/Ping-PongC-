using System;

namespace Game.Models {

    class Ping_pong
    {
        public void Count(int number)
        {
            for (int i = 1; i<=number; i++) 
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
    }
}