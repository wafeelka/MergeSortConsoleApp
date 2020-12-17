using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MergeSortApp
{// Метод считывает файлы из входных файлов и объеденияет их в один список
    class ReadInputFilesString
    {
        public List<string> GetString(string inputFile1, string inputFile2)
        {
            List<string> mainList = new List<string>();

            var inputArg1 = File.ReadAllLines(inputFile1, Encoding.Default).ToList();
            var inputArg2 = File.ReadAllLines(inputFile2, Encoding.Default).ToList();
            var  ConcatResult = inputArg1.Concat(inputArg2).ToList();
            for (int i = 0; i < ConcatResult.Count; i++)
            {
                mainList.Add(ConcatResult[i]);
            }

            return mainList;
        }
    }
}
