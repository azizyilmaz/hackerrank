using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                string _outputText = String.Empty;
                if (i % 3 == 0)
                    _outputText = "Fizz";
                if (i % 5 == 0)
                    _outputText += "Buzz";
                if (string.IsNullOrEmpty(_outputText))
                    _outputText = i.ToString();
                Console.WriteLine(_outputText);
            }
        }
    }
}
