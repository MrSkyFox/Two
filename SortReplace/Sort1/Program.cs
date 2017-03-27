using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20; //Кількість чисел для сортування
            Random random = new Random();
            Console.WriteLine("Сортування мисиву методом перестановки v0.1");
            Console.Write("Введiть початкове значення масиву: ");
            //Надання початкового і кінцевого значення об'єкту рандом.
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть кiнцеве значення масиву: ");
            int y = Convert.ToInt32(Console.ReadLine());
            //Генерування масиву чисел
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(random.Next(x,y));
            }
            //Виведення початкового масиву чисел
            Console.WriteLine("Початковий масив: ");
            foreach (var tempArray in mas)
            {
                Console.Write(tempArray + " ");
            }
            MSort(mas); //Виклик методу сортування масиву
            //Виведення відсортованого масиву чисел
            Console.WriteLine("\n" + "Вiдсортований масив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+ " ");
            }
            Console.WriteLine("\n" + "Для виходу натиснiть Enter.");
            Console.ReadKey();

        }
        static int[] MSort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                //Пошук мінімального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //Обмін елементів
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
    }
}
