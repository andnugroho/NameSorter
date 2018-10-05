using NameSorter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    /// <summary>
    /// Base class for getting data from multi sources.
    /// </summary>
    public abstract class DataServiceBase
    {
        /// <summary>
        /// Get unsorted data
        /// </summary>
        /// <returns></returns>
        public abstract string[] GetUnsortedData();

        public abstract void WriteSortedData(string[] data);
    }
}
