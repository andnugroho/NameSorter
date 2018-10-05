using NameSorter.Classes;
using NameSorter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    public class NameService : INameService
    {
        public List<NameClass> GetSortedNames(string[] unsortedNames)
        {
            try
            {
                List<NameClass> unsortedSplitNames = new List<NameClass>();

                //string[] unsortedNamesNew = new string[unsortedNames.Count()];
                //int i = 0;
                foreach (var name in unsortedNames)
                {
                    var splitNames = StringHelper.SplitString(name);
                    var lastName = splitNames[splitNames.Length - 1];
                    var givenName = name.Replace(" " + lastName, "");

                    //unsortedNamesNew[i++] = givenName + " " + lastName;

                    var nameClass = new NameClass { GivenName = givenName, LastName = lastName };

                    unsortedSplitNames.Add(nameClass);
                }

                

                var sortedNames = unsortedSplitNames.OrderBy(c => c.LastName).ThenBy(c => c.GivenName).ToList<NameClass>();

                return sortedNames;
            }
            catch (Exception ex)
            {
                // logger here
                return null;
            }

        }
    }
}
