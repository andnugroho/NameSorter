using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter.Classes;
using NameSorter.Common;
using System.IO;

namespace NameSorter.Services
{
    /// <summary>
    /// Class to get data from text file
    /// </summary>
    public class FileTextDataService : DataServiceBase
    {
        private string _fileName = "";
        private string _sortedFileName = "";

        public FileTextDataService(string fileName, string sortedFileName) {
            this._fileName = fileName;
            this._sortedFileName = sortedFileName;
        }

        /// <summary>
        /// Get unsorted data
        /// </summary>
        /// <returns></returns>
        public override string[] GetUnsortedData()
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();                
                string filePath = Path.Combine(currentDirectory, _fileName);

                string[] unsortedNames = File.ReadAllLines(filePath);
         
                return unsortedNames;
            }
            catch (Exception ex)
            {
                // logger here
                return null;                
            }
        }

        public override void WriteSortedData(string[] data)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, _sortedFileName);

                File.WriteAllLines(filePath, data);                
            }
            catch (Exception ex)
            {
                // logger here                
            }
        }
    }
}
