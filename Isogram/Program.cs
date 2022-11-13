using System;
using System.Linq;

namespace Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string _isogram = Console.ReadLine();
            int _isogramtrue = 0;

            foreach (char item in _isogram)
            {
                if (_isogram.Count(p => p == item) > 1) _isogramtrue++;
            }

            if (_isogramtrue > 0) Console.WriteLine("false");
            else Console.WriteLine("true");
        }
    }
}
