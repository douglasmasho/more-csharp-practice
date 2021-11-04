using System;
//dont forget to import these
using System.Collections.Generic;
using System.Linq;
/*
Write a program named SortWords that includes a method that accepts any number 
of words and sorts them in alphabetical order. Demonstrate that the program works 
correctly when the method is called with one, two, five, and ten words. 
*/


namespace question8chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortWords("Oh");
            Console.WriteLine("..........................");
            SortWords("Oh", "yeah");
            Console.WriteLine("..........................");
            SortWords("Oh", "yeah", "ay", "Halla", "Boyz");
            Console.WriteLine("..........................");
            SortWords("Oh", "yeah", "ay", "Halla", "Boyz", "Halla", "We", "Dem", "Boys", "Holla");
        }

        public static void SortWords(params string[] words)
        {
            List<string> wordList = words.ToList();

            wordList.Sort();

            string[] wordArr = wordList.ToArray();

            foreach(string word in wordArr)
            {
                Console.WriteLine(word);
            }
        }
    }
}
