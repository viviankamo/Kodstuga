using System;
using System.Collections.Generic;
using System.Linq;

namespace reverserot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabetArr = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '.', '_' };

            var input = new List<string>();

            while (true)
            {
                string word = Console.ReadLine();
                if (word.Equals("0") || word.Equals("")) break;
                try
                {
                    var rotation = Convert.ToInt32(word.Split(" ")[0].Trim());
                }
                catch
                {
                    break;
                }
                var message = word.Split(" ")[1].Trim();
                if (message.ToCharArray().Count() > 40) break;

                input.Add(word);
                if (input.Count() == 30) break;
            }

            foreach (var line in input)
            {
                var result = "";
                var rotation = Convert.ToInt32(line.Split(" ")[0].Trim());
                var message = line.Split(" ")[1].Trim();

                foreach (var letter in message.ToCharArray())
                {
                    var newIndex = alphabetArr.FindIndex(c => c == letter) + rotation;
                    newIndex = newIndex > 27 ? newIndex - 28 : newIndex;
                    var newChar = alphabetArr[newIndex];
                    result += newChar;
                }
                
                result = Reverse(result);
                Console.WriteLine(result);
            }
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}