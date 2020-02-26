using System;
using Game.Models;

namespace Game {
    
    public class Program
    {
        public static void Main()
        {   
            Ping_pong pong = new Ping_pong();
            Console.WriteLine("Enter a number:");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber); 
            Console.WriteLine("----------------");
            pong.Count(number);   
        }
    }
}