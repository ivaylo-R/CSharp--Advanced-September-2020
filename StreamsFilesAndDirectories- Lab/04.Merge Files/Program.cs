using System;
using System.IO;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader1 = new StreamReader("Input1.txt"))
            {
                using (var reader2 = new StreamReader("Input2.txt"))
                {
                    using (var writer = new StreamWriter("output.txt"))
                    {
                        int count = 0;
                        while (true)
                        {
                            if (count % 2 == 1)
                            {
                                var currSymbol = reader2.ReadLine();
                                if (currSymbol == null)
                                {
                                    break;
                                }
                                writer.WriteLine(currSymbol);
                            }
                            else
                            {
                                var currSymbol = reader1.ReadLine();
                                if (currSymbol == null)
                                {
                                    break;
                                }
                                writer.WriteLine(currSymbol);
                            }
                            count++;
                        }
                    }


                }


            }
        }
    }

}
