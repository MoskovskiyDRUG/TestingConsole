using NetTopologySuite.Algorithm;
using System;


namespace Testing
{
    class Program 
    {
        public static void Main(string[] args )
        {
            StartWindow();
            Wallking();
        }
       
        public static void StartWindow() 
        {
            string textOfTast_1 = "Привет. На примере данной " +
                "программы я хочу показать 'Парадокс Зенона'. \n" +
                "Суть парадокса такова: Движение невозможно. " +
                "В частности, невозможно пересечь комнату,\n " +
                "так как для этого нужно сначала пересечь \n " +
                "половину комнаты, затем половину оставшегося пути, \n " +
                "затем половину того, что осталось, затем \n" +
                "половину оставшегося... \n ...........................................................\n " +
                "";
            string textOfTast_2 = "Итак, для примера мы \n" +
                "возьмем расстояние в 100 метров и \n" +
                "сразу поделим его на 2. \n" +
                "Получается 50! То есть, нам остается  \n" +
                "лишь половина пройденного пути.... \n" +
                "Но все совсем не так однозначно и  \n" +
                "сейчас я попробую это доказать на примере: \n";
            Console.WriteLine(textOfTast_1 + textOfTast_2);
        }
        public static void Wallking()
        {
            int distanceWay = 100; // дистанция
            int stepCount = 0; // колличество циклов
            decimal distanceNow = 0; //разница расстояния
            decimal step = 0; // пройденное растояние 
            distanceNow = distanceWay / 2; // деление расстояния
            Console.WriteLine("Вы готовы начать? \n y/n?");
            string answerY = Console.ReadLine();
            if (answerY == "y")
            {
                Console.WriteLine(distanceNow); // да это кастыль и что?
                while (distanceNow < distanceWay && step != 50)
                {
                    distanceNow = distanceNow / 2;
                    step = distanceNow + step;
                    stepCount++;
                    Console.WriteLine(step);
                }
                Console.WriteLine(" \n ............................................................................................................" +
                    " \n  \n Поздравляем, это конец цикла. Так бывает когда твоя переменная понимает только 28 знаков после запятой! \n" +
                    " Тем не менее, на примере мы видим что с каждым последующим циклом - длинная пройденного расстояния уменьшается вдвое, \n " +
                    "что со временем достигнет момента, когда значения можно будет смело отправлять в погрешность. \n " +
                    "Спасибо за внимание!");
            }
        }
    }
    }

