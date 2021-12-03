using System;

namespace Ceaser_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            ///call the ceaser class 
            Ceaser Ceaser = new Ceaser();

           Console.WriteLine("Enter your message\r");
         ///read the user input
         String input = Console.ReadLine();
         ///read the shift number
         Console.WriteLine("Enter the shift number\r");
         int sheft = Convert.ToInt32(Console.ReadLine());
            Ceaser.encrypt(input, sheft);

        }
    }
}
