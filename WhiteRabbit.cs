using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WhiteRabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordFilepath = $"{Environment.CurrentDirectory}/wordlist";

            try
            {
                string[] lines = File.ReadAllLines(wordFilepath);
                var possibleWords = GetPossibleWords(lines);
            }
            catch
            {

            }
        }

        public static string[] GetPossibleWords(string[] words)
        {
            var solution = new List<string>();

            var easy = "e4820b45d2277f3844eac66c903e84be";
            var medium = "23170acc097c24edb98fc5488ab033fe";
            var hard = "665e5bcb0c20062fe8abaaf4628bb154";

            var input = "poultry outwits ants";
            var inputLength = input.Count();

            var letters = input.GroupBy(x => x)
                .Select(x => new { key = x.Key, count = x.Count() })
                .ToArray();

            var correctWords = new List<string>();

            foreach (var word in words)
            {
                var lettersInWord = word.GroupBy(x => x)
                    .Select(x => new { key = x.Key, count = x.Count() })
                    .ToArray();

                if (word.GroupBy(ch => ch).All(g => g.Count() <= input.Count(ch => ch == g.Key))
                    && !correctWords.Contains(word))
                {
                    correctWords.Add(word);
                }
            }

            long counter = 0;

            for (int i = 0; i < correctWords.Count(); i++)
            {
                for (int j = 0; j < correctWords.Count(); j++)
                {
                    for (int k = 0; k < correctWords.Count(); k++)
                    {
                        counter++;

                        var phrase = $"{correctWords[i]} {correctWords[j]} {correctWords[k]}";

                        if (phrase.Count() == inputLength)
                        {
                            if (phrase.GroupBy(ch => ch).All(g => g.Count() <= input.Count(ch => ch == g.Key)))
                            {
                                var hash = CreateMD5($"{correctWords[i]} {correctWords[j]} {correctWords[k]}");

                                Console.WriteLine($"{correctWords[i]} {correctWords[j]} {correctWords[k]} : {hash}");

                                if (hash == easy || hash == medium || hash == hard)
                                {
                                    solution.Add(phrase);
                                }
                            }
                        }
                    }
                }
            }

            return solution.ToArray();
        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
