using System;

namespace Home12
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Wheels wheel = new Wheels();
            Engines engines = new Engines();
            while (true)
            {
                Console.WriteLine("What list you wont? '1'-Cars '2'-Wheels '3'-Engines");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    cars.CarList();
                }
                if (i==2)
                {
                    wheel.WheelsModels();
                }
                if (i==3)
                {
                    engines.EnginesModels();
                }
            }
        }
        public class  Cars
        {                      
            string[] cars = { "Volkswagen", "Opel", "Mercedes" };
            public void CarList()
            {
                    for (int i = 0; i<cars.Length; i++)
                    {
                           Console.WriteLine(cars[i]);
                    }
            }
        }

        class Wheels : Cars
        {
            string[] WheelsList = { "Model 1.3(Volkswagen)", "Model 3.5(Opel)", "Model 2.5(Mercedes)" };
            public void WheelsModels()
            {
                for (int i = 0; i < WheelsList.Length; i++)
                {
                    Console.WriteLine(WheelsList[i]);
                }
            }
        }

        class Engines : Cars
        {
            string[] EngineList = { "Model 34x", "Model 45 r", "Model 12 kolo" };
            public void EnginesModels()
            {
                for (int i = 0; i < EngineList.Length; i++)
                {
                    Console.WriteLine(EngineList[i]);
                }
            }
        }
    }
}
