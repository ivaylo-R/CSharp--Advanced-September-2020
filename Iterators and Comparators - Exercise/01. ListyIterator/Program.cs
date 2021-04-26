using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main()
        {
            ListyIterator<string> list = null;
            while (true)
            {
                var input =Console.ReadLine().Split();
                string command = input[0];
                if (command == "END")
                {
                    break;
                }
                else if (command == "Create")
                {
                    var data = input.Skip(1).ToArray();
                    list = new ListyIterator<string>(data);
                    continue;
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                    continue;
                }
                else if (command == "Move")
                {
                    Console.WriteLine(list.Move());
                    continue;
                }
                else if (command=="Print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (InvalidOperationException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                else if (command=="PrintAll")
                {
                    try
                    {
                        list.PrintAll();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
