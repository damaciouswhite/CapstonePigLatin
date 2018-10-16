using System;


namespace Capstone1_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capstone 1 Pig Latin");
            Console.WriteLine("Hello! What is your name?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hey {0}!", UserName);



            Console.WriteLine("Please enter a word to convert to Pig Latin: ");
            string Word = Console.ReadLine().ToLower();
            int WheresTheVowel = Word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
            Console.WriteLine(ToPigLatin(Word, WheresTheVowel));


        }
            public static string ToPigLatin(string Word, int WheresTheVowel)
            {
                int i = 0;
                if (WheresTheVowel == -1)
                {
                    Word = Word + "way";
                }

                else
                {
                    for (; i < WheresTheVowel; i++)
                    {
                        Word = Word + Word[i];
                    }
                    Word = Word.Substring(i);
                    Word = Word + "ay";

                }
                return Word;


            }

        }
    }

