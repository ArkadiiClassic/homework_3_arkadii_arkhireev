using System;

namespace example_1
{
    /// <summary>
    /// Структура для представления комплексного числа
    /// </summary>
    struct Complex
    {
        public double im;
        public double re;

        /// <summary> Метод сложения с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для сложения</param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary> Метод разности с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для разности</param>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        /// <summary> Метод произведения с другим комплексным числом </summary>
        /// <param name="x">Комплексное число для произведения</param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary> Метод представления комплексного числа в удобной форме</summary>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №3 пример_1
            // Архиреев Аркадий 
            /* 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
             * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
             * в) Добавить диалог с использованием switch демонстрирующий работу класса.*/
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Результат работы структуры:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Рассмотрим результат работы класса:");
            CComplex ccomplex1 = new(1, 1);
            CComplex ccomplex2 = new(2, 2);
            ccomplex2.Im = 3;
            CComplex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());

            Console.ReadKey();
        }
    }
}
