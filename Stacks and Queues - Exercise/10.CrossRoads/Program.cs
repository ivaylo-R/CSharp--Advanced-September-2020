using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueOfCars = new Queue<string>();

            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            bool isHittted = false;
            string hittedCarName = string.Empty;
            char hittedSymbol = '\0';
            int totalCars = 0;
            while (true)
            {
                var input =Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                }
                else
                {
                    int currentGreenLightDuration = greenLightDuration;
                    while (currentGreenLightDuration > 0 && queueOfCars.Any())
                    {
                        string carName = queueOfCars.Dequeue();
                        int carLength = carName.Length;

                        if (currentGreenLightDuration - carLength >= 0)
                        {
                            currentGreenLightDuration -= carLength;
                            totalCars++;
                        }
                        else
                        {
                            currentGreenLightDuration += freeWindowDuration;
                            if (currentGreenLightDuration - carLength >= 0)
                            {
                                totalCars++;
                                break;
                            }
                            else
                            {
                                isHittted = true;
                                hittedCarName = carName;
                                hittedSymbol = carName[currentGreenLightDuration];


                            }
                        }
                    }
                }
                if (isHittted)
                {
                    break;
                }

            }
            if (isHittted)
            {
                Console.WriteLine($"A crash happened!");
                Console.WriteLine($"{hittedCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
