using NameSorter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    public class NameService
    {
        public NameClass SplitName(string inputName)
        {
            var splitNames = inputName.Split(' ');
            var lastName = splitNames[splitNames.Length - 1];
            var givenName = inputName.Replace(" " + lastName, "");

            var nameClass = new NameClass { GivenName = givenName, LastName = lastName };

            return nameClass;
        }
    }
}
