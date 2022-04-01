using System;
using System.Globalization;


namespace Sharp_ClassConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;
           

            Console.WriteLine("Введите число 1");

            //сохранение считанной с консоли строки в переменную
            str = Console.ReadLine();

            //конвертация введенной строки в целочисленный тип и присваивание сконвертированного значения переменной a
            a= Convert.ToInt32(str);

            Console.WriteLine("Ведите число 2");

            //сохранение считанной с консоли строки в переменную
            str = Console.ReadLine();

            //конвертация введенной строки в целочисленный тип и присваивание сконвертированного значения переменной b
            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine($"Сумма чисел = {result}");

            Console.WriteLine("Ведите дробное число 1 (с разделитем /)");

            str = Console.ReadLine();

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                //присваиваем полю NumberDecimalSeparator символ разделителя который будем использовать привводе дробного числа в консоль(символ может быть любой)
                NumberDecimalSeparator = "/",
            };

            //вторым параметром указываем numberFormatInfo, который хранит ранее указанный разделитель дробного числа
            double c = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine("Ведите дробное число 2 (с разделитем /)");

            str = Console.ReadLine();

            double d = Convert.ToDouble(str, numberFormatInfo);

            double result2 = c + d;

            Console.WriteLine($"Сумма чисел = {result2}");
        }
    }
}
