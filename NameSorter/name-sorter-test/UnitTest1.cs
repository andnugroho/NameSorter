using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Services;

namespace name_sorter_test
{
    /// <summary>
    /// sample testing
    /// </summary>

    [TestClass]
    public class UnitTest1
    {        

        [TestMethod]
        public void Get_Unsorted_Names_Test()
        {
            FileTextDataService _dataService = new FileTextDataService("unsorted-names-list.txt", "sorted-names-list.txt");

            string[] InputStrings = new string[] {
                "Orson Milka Iddins",
                "Erna Dorey Battelle",
                "Flori Chaunce Franzel"
            };

            var unsortedNames = _dataService.GetUnsortedData();

            int i = 0;
            foreach (var name in unsortedNames)
            {
                if (i == 3)
                {
                    break;
                }
                else
                {
                    if (name != InputStrings[i])
                    {
                        Assert.Fail(name + " is not correct");
                    }
                    
                }

                i++;
            }
            
           
        }
    }
}
