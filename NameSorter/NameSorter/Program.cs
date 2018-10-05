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
            args = new string[] { "./unsorted-names-list.txt" };

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
                            // get filename from input parameters
                            fileName = args[0].Replace("./", "");
            
                            var _dataService = new FileTextDataService(fileName, "sorted-names-list.txt");

                            Console.WriteLine("");
                            Console.WriteLine("UNSORTED NAMES :");
                            Console.WriteLine("");

                            // Get unsorted names
                            var unsortedNames = _dataService.GetUnsortedData();
                            foreach (var name in unsortedNames)
                            {
                                Console.WriteLine(name);                                
                            }

                            Console.WriteLine("");
                            Console.WriteLine("SORTED NAMES :");
                            Console.WriteLine("");
                            
                            INameService _nameService = new NameService();
                            
                            // Get sorted names
                            var sortedNames = _nameService.GetSortedNames(unsortedNames);

                            foreach (var item in sortedNames)
                            {
                                Console.WriteLine(item.GivenName + " " + item.LastName);
                            }

                            // Write sorted names to text file
                            string[] sortedStrings = sortedNames.Select(c => c.GivenName + " " + c.LastName).ToArray();
                            _dataService.WriteSortedData(sortedStrings);
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
