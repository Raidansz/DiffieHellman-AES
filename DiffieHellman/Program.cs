using System;
using System.Globalization;
using System.Numerics;

namespace Diffiehellman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // We first create two users Bob && Alice
            Console.WriteLine("First user : Alice. ");
            User Alice = new User("Alice");
            Console.WriteLine("Second user : Bob ");
            User Bob = new User("Bob");

            Console.WriteLine("Keys are being generated....");
            System.Threading.Thread.Sleep(500);
            //We generate two random numbers for a and b
            Console.ForegroundColor = ConsoleColor.Green;
            Alice.Generate_Key();
            Bob.Generate_Key();
            Console.WriteLine("Generating Keys: Done!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Keys are being exchanged...");
            System.Threading.Thread.Sleep(500);
            // keys are being exchanged
            Alice.ExchangeKeys(Bob.GeneratedPublicKey, Bob.I_V);
            Bob.ExchangeKeys(Alice.GeneratedPublicKey, Alice.I_V);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Keys are sucsessfully exchanged");
            Console.ResetColor();
            // Keys are sucsessfully exchanged!
            //============
            Console.WriteLine("=================================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            // After recieving ---> Decrupt ---> write to the console
            // Alice recieves a message from Bob // Encrupt --> Send ---> Recieve
            Alice.Recieve(Bob.SendMyMessage("How are you,Alice?"));
            //Bob receives a message from Alice // Encrupt --> Send ---> Recieve
            Bob.Recieve(Alice.SendMyMessage("I am fine. Thanks! What about you?"));
            Console.ResetColor();
            Console.ReadLine();

        }
    }
}





