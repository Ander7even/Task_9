using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");



            try
            {
                Console.Write("Введите целое число X=");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                decimal y = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n     1 - cложение \n     2 - вычитание \n     3 - умножение \n     4 - частное ");
                Console.WriteLine("Ваш выбор:");


                int cmd = Convert.ToInt32(Console.ReadLine());

                switch (cmd)
                {


                    case 1:
                        {
                            Console.WriteLine("Результат равен = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен = {0:f2}", x / y);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером!");
                            break;
                        }

                }


            }

            catch (Exception exc)
            {
                Console.WriteLine("Ошибка! "+ exc.Message);
            }
            Console.ReadKey();




        }
    }
}

















