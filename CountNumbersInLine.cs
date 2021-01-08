using System;

namespace TestQuest
{
    class CountNumbersInLIne
    {
        private static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Пограмма, которая подсчитывает количество повторений каждого числа, встреченного в заданной строке.");
                Console.WriteLine("Введите строку или \"q\" для выхода.");
                if (Console.Read() == 'q') break;
                else CountNumbers(Console.ReadLine());


            } while (true);
        }

        private static void CountNumbers(string line)
        {
            int[] count = new int[10];

            foreach (char a in line)
            {
                switch (a)
                {
                    case '0':
                        count[0]++;
                        break;
                    case '1':
                        count[1]++;
                        break;
                    case '2':
                        count[2]++;
                        break;
                    case '3':
                        count[3]++;
                        break;
                    case '4':
                        count[4]++;
                        break;
                    case '5':
                        count[5]++;
                        break;
                    case '6':
                        count[6]++;
                        break;
                    case '7':
                        count[7]++;
                        break;
                    case '8':
                        count[8]++;
                        break;
                    case '9':
                        count[9]++;
                        break;
                    default:
                        continue;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    Console.WriteLine("{0}: {1}", i, count[i]);
            }

            Console.ReadKey();
        }
    }
}
