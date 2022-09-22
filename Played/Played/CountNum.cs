using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Played
{
    class Calc
    {
        static float result;

        internal static string CountNum(string firstNumber,
        string secondNumber,
        string operation) 
        {
           switch (operation)
            {
                case "-":
                    result = float.Parse(firstNumber) - float.Parse(secondNumber);
                    break;

                case "+":
                    result = float.Parse(firstNumber) + float.Parse(secondNumber);
                    break;

                case "/":
                    result = float.Parse(firstNumber) / float.Parse(secondNumber);
                    break;

                case "*":
                    result = float.Parse(firstNumber) * float.Parse(secondNumber);
                    break;
            }

            return result.ToString();
        }
    }
}
