using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main() 
        {
            //consoleSum();
            //nameAgeTown();
            //multiplicationTable();
            //isEvenOrOdd();
            //isAnagramm();
            searchWordByFirstLetter();
          
        }


        //Создание консольного приложения, запрашивающего у
        //пользователя два числа и выводящего на экран их сумму:
        static void consoleSum() 
        {
            Console.WriteLine("Введите первое число..");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число..");
            int num_2 = int.Parse(Console.ReadLine());

            int sum = num_1 + num_2;
            Console.WriteLine($"Сумма чисел {num_1} + {num_2} = {sum}");
        }

        //Создание консольного приложения, запрашивающего у пользователя имя, возраст
        //и город проживания и выводящего на экран приветствие:
        static void nameAgeTown() 
        {
            Console.WriteLine("Введите ваше имя..");
            string name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст..");
            UInt32 age = uint.Parse(Console.ReadLine());

            Console.WriteLine("Введите название города вашего проживания..");
            string address = Console.ReadLine();

            Console.WriteLine($"Привет,{name}! Тебе {age} лет и ты живешь в городе {address}.");
        }

        //Создание консольного приложения, выводящего на экран таблицу умножения от 1 до 10:
        static void multiplicationTable() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }

        //Создание консольного приложения, запрашивающего у пользователя
        //целое число и проверяющего, является ли оно четным:
        static void isEvenOrOdd()
        {
            Console.WriteLine("Введите число для проверки на четность..");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) 
            {
                Console.WriteLine($"Число {number} является четным");
            }
            else 
            {
                Console.WriteLine($"Число {number} является нечетным");
            }
        }

        //Создание консольного приложения, запрашивающего у пользователя
        //два слова и проверяющего, являются ли они анаграммами:

        //Анаграмма - это слово или фраза, полученная перестановкой букв другого слова или фразы.
        //Например, слова "ветер" и "верет" являются анаграммами, так как они состоят из одних и
        //тех же букв, но в разном порядке. Анаграммы могут использоваться в играх или головоломках
        //для развития лингвистических и когнитивных способностей, а также для развлечения.
        // кот ток
        // барокко коробка
        static void isAnagramm()
        {
            Console.WriteLine("Введите первое слово..");
            string word_1 = Console.ReadLine();

            Console.WriteLine("Введите второе слово..");
            string word_2 = Console.ReadLine();

            //логика анограммы - два слова являются анограммой когда
            // 0. превратить исходные данные в наборы символов
            // 1. совпадает количество букв в слове
            // 2. все буквы и количество каждой совпадают

            char[] charArrayFromWord_1 = word_1.ToLower().ToCharArray();
            char[] charArrayFromWord_2 = word_2.ToLower().ToCharArray();

            Array.Sort(charArrayFromWord_1);
            Array.Sort(charArrayFromWord_2);

            bool flag = false;

            if (charArrayFromWord_1.Length == charArrayFromWord_2.Length)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (flag) {
                for (int i = 0; i < charArrayFromWord_1.Length; i++)
                {
                    if (charArrayFromWord_1[i] != charArrayFromWord_2[i]) 
                    {
                        flag = false ; 
                        break ;
                    }
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Введенные слова не анограмма");
            }
            else
            {
                Console.WriteLine("Введенные слова анограмма");
            }
        }

        //Создать консольное приложение, которое запрашивает у пользователя имя и выводит на экран его инициалы в формате "И. О." (первая буква имени и первая буква отчества).

        //Создать консольное приложение, которое запрашивает у пользователя число N и выводит на экран первые N чисел Фибоначчи.

        //Создать консольное приложение, которое запрашивает у пользователя строку и выводит на экран все ее подстроки.
        static void searchWordByFirstLetter()
        {
            Console.Write("Введите список слов через запятую: ");
            string input = Console.ReadLine();

            Console.Write("Введите букву: ");
            char letter = Console.ReadKey().KeyChar;

            string[] words = input.Split(',');

            List<string> wordsStartingWithLetter = new List<string>();

            foreach (string word in words)
            {
                if (word.Trim().StartsWith(letter.ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    wordsStartingWithLetter.Add(word.Trim());
                }
            }

            Console.WriteLine($"\nСлова, начинающиеся с буквы {letter}:");
            foreach (string word in wordsStartingWithLetter)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

        //Создать консольное приложение, которое запрашивает у пользователя список слов и выводит на экран только те слова, которые начинаются с заданной буквы.

        //Создать консольное приложение, которое генерирует случайный пароль заданной длины из заданных символов (например, только цифры и заглавные буквы).
    }
}
