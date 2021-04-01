using System;
using System.Linq;
using System.Collections.Generic;


namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int sizeOfTheGun = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfInt = int.Parse(Console.ReadLine());
            int currentBarrel = sizeOfTheGun;
            var locksQueue = new Queue<int>(locks);
            var bulletsStack = new Stack<int>(bullets);
            int totalBullets = bulletsStack.Count;
            while (locksQueue.Any() || bulletsStack.Any())
            {

                if (!bulletsStack.Any())
                {
                    break;
                } 
                if (!locksQueue.Any())
                {
                    break;
                }
                int currentBullet = bulletsStack.Pop();
                currentBarrel--;
                int currentLock = locksQueue.Peek();
                if (currentBullet>currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                else if (currentBullet<=currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locksQueue.Dequeue();
                }
                if (currentBarrel==0 && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = sizeOfTheGun;
                }
            }

            
            if(!locksQueue.Any())
            {
                int bulletsUsed = totalBullets - bulletsStack.Count();
                int sumOfBulletsUsed = bulletsUsed * price;
                int moneyEarned = valueOfInt - sumOfBulletsUsed;

                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
                return;
            }
            else if (!bulletsStack.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
                return;
            }
        }
    }
}
