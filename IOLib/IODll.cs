using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOLib
{
    public class IODll
    {
        private static readonly byte MIN_ARR_LENGTH = 2;

        public static int[] GetIntArrayFromKeyboard()
        {
            int[] _intArr = { };
            bool _isStrOk = false;

            do
            {
                PrintInfoMessage("Enter integer numbers separate by the sapces: ");

                String _strArr = Console.ReadLine();
                try
                {
                    _intArr = Array.ConvertAll<string, int>(_strArr.Split(' '), int.Parse);
                    _isStrOk = true;

                    if (_intArr.Length < MIN_ARR_LENGTH)
                    {
                        PrintErrorMessage("You should enter minimum 2 numbers! Please try again!");
                        _isStrOk = false;
                    }
                }
                catch (Exception)
                {
                    PrintErrorMessage("Input is not correct! Please try again!");
                }

            } while (!_isStrOk);
            



            return _intArr;
        }

        public static void PrintErrorMessage(String error)
        {
            ConsoleColor _color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = _color;
        }

        public static void PrintInfoMessage(String msg)
        {
            ConsoleColor _color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(msg);
            Console.ForegroundColor = _color;
        }
    }
}
