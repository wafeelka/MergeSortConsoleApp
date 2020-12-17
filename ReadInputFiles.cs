using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MergeSortApp
{ // Метод считывает файлы из входных файлов и объеденияет их в один список
     class ReadInputFiles
    {
        public List<int> GetInt(string inputFile1, string inputFile2)
        {
            List<int> mainList = new List<int>();

           var inputArg1 = File.ReadAllLines(inputFile1, Encoding.Default).ToList();
           var inputArg2 = File.ReadAllLines(inputFile2, Encoding.Default).ToList();
           var ConcatResult =  inputArg1.Concat(inputArg2).ToList();
            for (int i = 0; i < ConcatResult.Count; i++)
            {
                mainList.Add(int.Parse(ConcatResult[i]));
            }

            return mainList;
        }
    }
}
