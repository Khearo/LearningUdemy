using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning // Udemy course
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Tries();
            Factorial();
            Average();
        }

        private static void Average()
        {
            int[] numbers = new int[10]; // массив из 10 символов
            int inputCount = 0; // счетчик массива  

            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number; //Введенное записываем в массив
                inputCount++;

                if (number == 0) // Получаем введенное 0 - заканчивается выполнение итерации.
                    break;
            }

            // Подсчет среднего арфиметическое значения кратного 3м. 

            int sum = 0;
            int count = 0;

            foreach (int n in numbers) // чтобы пройтись по всем введеным числам массива
            {
                if (n > 0 && n % 3 == 0) // n>0 и делится без остатка на 3. 
                {
                    sum += n;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine(average);
        }
        private static void Factorial()
        {
            Console.WriteLine("Enter the factorial number you want:");
            int number = int.Parse(Console.ReadLine());

            long factorial = 1;  
            for (int i = 1; i <= number; i++)
            {
                factorial *= i; // из формулы факториала : перемножение всех чисел фаториала между собой.
            }
            Console.WriteLine(factorial);
        }
        private static void Tries()
        {
            Console.WriteLine("Authorization");


            /*for (int count = 3; count > 0; count--)                // Цикл for для таких случаев не очень подходит.
            {
                  Console.WriteLine("\n\rEnter login:");
                  string login = Console.ReadLine(); ;


                  Console.WriteLine("Enter password:");
                  string password = Console.ReadLine();


                 if (login != "johnsilver" && password != "qwerty")
                 {
                      Console.WriteLine($"\n\rWrong, try again. The number of tries left is {count - 1}");
                      if (count == 0)
                      {
                          Console.WriteLine("\n\rThe number of available tries have been exceeded");
                          break;

                      }
                 }

                 else
                 {
                      Console.WriteLine("\n\rEnter the System");
                      break;
                 }
            } */

            int enterTry = 1;

            do
            {
                Console.WriteLine("\n\rEnter login:");
                string login = Console.ReadLine(); ;

                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                if (login != "silver" && password != "qwerty")
                {
                    Console.WriteLine($"\n\rWrong, try again. The number of tries is {enterTry}");
                    enterTry++;
                }
                else
                {
                    Console.WriteLine("\n\rEnter the System");
                    break;
                }


            }
            while (enterTry <= 3);

            if (enterTry == 4)
            {
                Console.WriteLine("\n\rThe number of available tries have been exceeded");
            }
            Console.ReadKey();
        }
    }
}