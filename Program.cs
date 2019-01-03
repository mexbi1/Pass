using System;

namespace ДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            float allDist = 10;
            int Day = 1;
            float distance = 10;
            while (allDist < 100)
            {
                if (Day % 2 == 0)  
                {
                    
                    distance += distance / 10;
                    allDist += distance;
                }
                Day++;
                Console.WriteLine($"Дистанция равняется {allDist}км на {Day} день");

            }
            Console.WriteLine("Дистанция на {0} день, будет равна {1} км", Day,allDist);
            
                Console.ReadKey();

            }
          
        }
    }

