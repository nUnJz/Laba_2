﻿using System;

namespace Laba_2_4
{
    class Program
    {
        delegate int StringLengthDelegate(string s);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            List<string> strings = new List<string> 
            {
                "Садок вишневий коло хати,",
                "Хрущі над вишнями гудуть,",
                "Плугатарі з плугами йдуть,",
                "Співають ідучи дівчата,",
                "А матері вечерять ждуть."
            };

            // Create a delegate that takes a string and returns its length
            StringLengthDelegate stringLength = s => s.Length;

            string s1 = "Шевченко";
            Console.WriteLine($"Рядок'{s1}' довжина: {s1.Length}");
            Console.WriteLine();

            // Use the delegate to process the list of strings
            foreach (string s in strings)
            {
                int length = stringLength(s);
                Console.WriteLine($"Рядок'{s}' довжина: {length}");
            }

            Console.ReadLine();
        }
    }
}