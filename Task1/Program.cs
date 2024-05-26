using System.Data;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWord("salam"));
        }

        static string ReverseWord(string word)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < word.Length; i++)
                stack.Push(word[i]);

            string reversedWord = string.Empty;
            while (stack.Count > 0)
            {
                reversedWord += stack.Pop();
            }

            return reversedWord;
        }
    }
}
