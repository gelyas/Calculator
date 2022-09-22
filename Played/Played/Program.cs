using Played;
using System;

namespace CalculyatorWithTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPlayed tests = new TestPlayed(); //Тест приложения
            tests.TestStart();

            Program.StartCalc();

        }

        internal static void StartCalc()
        {
            string firstNumber;
            string secondNumber;
            string operation;
            string result;


            try
            {
                Console.WriteLine("Введите число 1:");
                firstNumber = Console.ReadLine();

                Console.WriteLine("Введите число 2:");
                secondNumber = Console.ReadLine();

                Console.WriteLine("Какую операцию применим к числам:");
                operation = Console.ReadLine();

                //Calc count = new Calc();
                result = Calc.CountNum(firstNumber, secondNumber, operation); //высчитывание результата
                Console.WriteLine(result); //вывод результата

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            StartCalc();
        }

    }

}

public readonly struct Fraction
{
    private readonly string num;
    //private readonly int den;

    public Fraction(string numerator)
    {
        if (numerator == "0")
        {
            throw new ArgumentException("Denominator cannot be zero.", nameof(numerator));
        }
        num = numerator;
        //den = denominator;
    }



    //public static Fraction operator +(Fraction a, Fraction b)
    //    => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);


    //public static Fraction operator лох слова и разные стринги не пойдет сюда вставлять, так как предназначен только для операндов (Fraction a, Fraction b)
    //{
    //    if (b.num == 0)
    //    {
    //        throw new DivideByZeroException();
    //    }
    //    return new Fraction(a.num * b.den, a.den * b.num);
    //} 




    //public override string ToString() => $"{num} / {den}";


}


