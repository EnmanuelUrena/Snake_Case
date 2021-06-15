using System;

namespace Snake_Case
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string text = convertSnakeCase(Console.ReadLine());
            System.Console.WriteLine(text);
        }
        public static string convertSnakeCase(string text)
        {
            if (text == "")
            {
                throw new NullReferenceException();
            }
            bool isValidString = false;

            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == ' ')
                {
                    characters[i] = '_';
                    isValidString = true;
                }
            }
            if (isValidString == false)
            {
                throw new ArgumentNullException();
            }
            return new string(characters);
        }
    }
}
