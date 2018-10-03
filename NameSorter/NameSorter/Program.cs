using NameSorter.Classes;
using NameSorter.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            // for debug purpose
            //args = new string[] { "./unsorted-names-list.txt" };

            try
            {
                if (args == null)
                {
                    Console.WriteLine("args is null");
                }
                else
                {
                    if (args.Length > 0)
                    {
                        var param = args[0].Substring(0, 2);

                        string fileName = "";

                        if (param == "./")
                        {

                            var nameService = new NameService();

                            fileName = args[0].Replace("./", "");

                            string currentDirectory = Directory.GetCurrentDirectory();
                            Console.WriteLine(currentDirectory);

                            string filePath = Path.Combine(currentDirectory, fileName);
                            Console.WriteLine(filePath);

                            string[] unsortedNames = File.ReadAllLines(filePath);

                            List<NameClass> nameClass = new List<NameClass>();
                            
                            foreach (var name in unsortedNames)
                            {
                                Console.WriteLine(name);
                                nameClass.Add(nameService.SplitName(name));
                            }

                            Console.WriteLine("");
                            Console.WriteLine("SORTED NAMES");
                            Console.WriteLine("");
                            var sortedNames = nameClass.OrderBy(c => c.LastName).ThenBy(c => c.GivenName);

                            foreach (var item in sortedNames)
                            {
                                Console.WriteLine(item.GivenName + " " + item.LastName);
                            }

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Please input the arguments, for sample : name-sorter ./filename.txt");
                    }

                }
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }
    }
}
