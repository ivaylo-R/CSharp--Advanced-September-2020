using System;
using System.Collections.Generic;

namespace _07._V
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Statistics")
                {
                    break;
                }
                else if (line.Contains("joined"))
                {
                    string[] lineSplitted = line.Split();
                    var vlogger = lineSplitted[0];
                    if (!dict.ContainsKey(vlogger))
                    {
                        Vloggers newVlogger = new Vloggers(vlogger,new string[] { });
                        dict.Add(vlogger, 0);
                    }
                }
                else if (line.Contains("followed"))
                {
                    var lineSplitted = line.Split();
                    var firstVlogger = lineSplitted[0];
                    var secondVlogger = lineSplitted[1];
                    if (firstVlogger!=secondVlogger)
                    {
                        if (dict.ContainsKey(secondVlogger))
                        {
                            if (dict.ContainsKey(firstVlogger))
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
    class Vloggers
    {
        public string Name { get; set; }
        public string[] Followers { get; set; }


        public Vloggers(string name, string[] followers)
        {
            this.Name = name;
            this.Followers = followers;
        }
    }
}
