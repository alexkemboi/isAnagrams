using System;
class Program
{
    static bool isAnagrams(string[] words)
    {
        int[] charCount = new int[26];

        // Count characters in the first word
        foreach (char letter in words[0])
        {
            if (letter >= 'a' && letter <= 'z')
            {
                charCount[letter - 'a']++;
            }
        }

        // Subtract characters in the second word
        foreach (char letter in words[1])
        {
            if (letter >= 'a' && letter <= 'z')
            {
                charCount[letter - 'a']--;
            }
        }

        // Check if all character counts are zero
        foreach (int count in charCount)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
    static void Main(string[] args)
    {
        string[] words = new string[2];
        for (int i = 0; i < words.Length;i++)
        {
            Console.WriteLine($"Enter the {(i == 0 ? "first":"second")} word");
            words[i] = Console.ReadLine();
        }
        bool results = isAnagrams(words);
        if (results)
        {
            Console.Write("Words enterd are anagrams");
        }
        else
        {
            Console.Write("Words entered are not anagrams");
        }
    }
}