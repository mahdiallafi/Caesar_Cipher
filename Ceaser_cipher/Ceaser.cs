using System;
using System.Text.RegularExpressions;

namespace Ceaser_cipher
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class Ceaser
    {
        static char[] alphabete_letter = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r','s'
                   ,'t','u','v','w','x','y','z'};
        private string text;
        private int value;
        /// <summary>
        /// empty constructor 
        /// </summary>
        public Ceaser()
        {
           
        }
        /// <summary>
        /// Ceaser constructor 
        /// </summary>
        /// <param name="Text">textplain</param>
        /// <param name="Value">shift number</param>
        public Ceaser(String Text, int Value)
        {
            this.text = Text;
            this.value = Value;
        }
        /// <summary>
        /// encrypt method to convert the textplain 
        /// </summary>
        /// <param name="input"> the textplain</param>
        /// <param name="sheft"> sheft number</param>
        /// <returns></returns>
        public string encrypt(String input, int shift)
        {
            //convert the string message to array of charachters
            char[] message = input.ToLower().ToCharArray();
            ///use regex to ignore the expression letter like !;,
            Regex.IsMatch(input, "^[a-zA-Z]+$");
            //create the array of charachter to hold the message lenght
            char[] encryptedMessage = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    encryptedMessage[i] = ' ';
                    continue;
                }
                else
                {
                    char letterInMessage = message[i];
                    int letterPosition = Array.IndexOf(alphabete_letter, letterInMessage);
                    int newPosition = (letterPosition + shift) % 26;
                    //find the charchter with new position 
                    char letterencypted = alphabete_letter[newPosition];
                    encryptedMessage[i] = letterencypted;
                }
            }
            string encodedMessage = String.Join("", encryptedMessage);
            Console.WriteLine("your message is:  " + $"{encodedMessage}\r");
            return encodedMessage;
        }
    }
}