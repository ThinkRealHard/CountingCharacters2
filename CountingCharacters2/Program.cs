using System;
using System.Collections.Generic;

namespace CountingCharacters2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus";

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char character in lorem)
            {
                if (Char.IsLetter(character))
                {
                    if (letters.ContainsKey(character))
                    {
                        letters[character] += 1;
                    }
                    else
                    {
                        letters.Add(character, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> count in letters)
            {
                Console.WriteLine($"{count.Key} : {count.Value}");
            }
        }
    }
}
