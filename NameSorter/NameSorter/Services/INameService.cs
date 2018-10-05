using NameSorter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    public interface INameService
    {
        List<NameClass> GetSortedNames(string[] unsortedNames);
    }
}
