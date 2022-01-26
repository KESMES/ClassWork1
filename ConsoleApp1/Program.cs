using System;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string words = ReadFile(@"D:\Новая папка/Text.txt");
            CalcWords(words);
        }
        static string[] ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadToEnd();
            string[] words = line.Split(' ', ',', '.', '?', '\n');

            return words;
        }
        static void CalcWords(string path)
        {
            string vowels = "аеёиоуыэюя";
            string cons = "бвгджзйклмнпрстфхцчшщъь";
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadToEnd();
            string[] words = line.Split(' ', ',', '.', '?', '\n');
            foreach (string word in words)
            {
                int vowelsCount = 0;
                int ConsCount = 0;
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (word.Contains(vowels[i]))
                    {
                        vowelsCount++;
                    }
                }
                for (int i = 0; i < cons.Length; i++)
                {
                    if (word.Contains(cons[i]))
                    {
                        ConsCount++;
                    }
                }

                if (vowelsCount > ConsCount)
                {
                    Console.WriteLine($"{word} has a {vowelsCount} гласные, и {ConsCount} согласные");
                }
            }
        }
    }
}
