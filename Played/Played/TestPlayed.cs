using CalculyatorWithTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Played
{
    class TestPlayed
    {
        //В чем заключается прикол теста. Подает исходные данные в программу. Все прогоняет до начала действий пользователя. Проверяет так скажем корректность системы
        internal void TestStart()
        {
            TestDivNull();
            TestMult();
            TestSub();
            TestAdd();        }

        private void TestDivNull()
        {
            Program program = new Program();
            Console.WriteLine("я в тесте деления на ноль");

            //Calc count = new Calc(); //почему то через новый экземпляр с ошибкой 
            string result = Calc.CountNum("1", "0", "/");
            
            if (result == "∞")
            {
                Console.WriteLine("Проверка деления на ноль прошел успешно");
            }
            else
            {
                throw new ArgumentException("Деление сломано", nameof(result));
            }
            
        }

        private void TestMult()
        {
            Program program = new Program();
                        //Calc count = new Calc(); //почему то через новый экземпляр с ошибкой 
            string result = Calc.CountNum("1", "2", "*");

            if (result == "2")
            {
                Console.WriteLine("Умножение работает корректно");
            }
            else
            {
                throw new ArgumentException("Умножение сломано", nameof(result));
                
            }
        }

        private void TestSub()
        {
            Program program = new Program();
            //Calc count = new Calc(); //почему то через новый экземпляр с ошибкой 
            string result = Calc.CountNum("1", "2", "-");

            if (result == "-1")
            {
                Console.WriteLine("Вычитание работает корректно");
            }
            else
            {

                throw new ArgumentException("Вычитание сломано", nameof(result));
            }
        }

        private void TestAdd()
        {
            Program program = new Program();
            //Calc count = new Calc(); //почему то через новый экземпляр с ошибкой 
            string result = Calc.CountNum("1", "2", "+");

            if (result == "3")
            {
                Console.WriteLine("Сложение работает корректно");
            }
            else
            {

                throw new ArgumentException("Сложение сломано", nameof(result));
            }
        }
    }
}
