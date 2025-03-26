using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input one line of words (S) : ");
        string input = Console.ReadLine().ToLower(); 
        List<char> vowels = new List<char>();
        List<char> consonants = new List<char>();
        char[] vowelChars = { 'a', 'e', 'i', 'o', 'u' };
        foreach (char c in input)
        {
            if (char.IsLetter(c)) 
            {
                if (vowelChars.Contains(c))
                    vowels.Add(c); 
                else
                    consonants.Add(c); 
            }
        }
        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(string.Join("", vowels));
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(string.Join("", consonants));
    }
}