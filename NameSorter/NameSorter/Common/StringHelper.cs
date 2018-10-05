using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Common
{
    public static class StringHelper
    {
        public static string[] SplitString(string inputText)
        {
            var splitString = inputText.Split(' ');            
            return splitString;
        }
    }
}
