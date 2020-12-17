using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortApp
{
    static class ArgsReading
    {
        static public void CheckCorrectArgs(string[] userInput)
        {
            //блок экземпляров для чисел
            ReadInputFiles inputIntCollection = new ReadInputFiles();
            MergeSort<int> EndResultInt = new MergeSort<int>();
            List<int> resultSort = new List<int>();

            //блок экземпляров для строк
            ReadInputFilesString inputStringCollectionString = new ReadInputFilesString();
            MergeSort<string> EndResultString = new MergeSort<string>();
            List<string> resultSortString = new List<string>();

            int i = 0;
            bool flag = true;
            while (flag == true && i < userInput.Length)
            {
                if (userInput[i] == "-help")
                {
                    ShowManual();
                    break;
                }
                if(userInput.Length < 5)
                {
                    Console.WriteLine("Указано недопустимое количество параметров.При запуске обязательно указать:" +
                                      "\n 1) Тип данных для сортировки \n 2) Имя выходного файла \n 3) Имя выходного файла. " + "4)Имя входного файла 1. \n5) Имя входного файла 2." +
                                      "\nПрочитайте инструкцию и перезапустите программу, указав верное значение аргументов\n");
                    ShowManual();
                    flag = false;
                }
                else
                {
                    switch (userInput[0])
                    {
                        case "-d":
                            Condition1Args(userInput[0], userInput);
                            break;
                        case "-a":
                            Condition1Args(userInput[0], userInput);
                            break;
                        default:
                            Console.WriteLine(" Введено неверное значение 1 - го аргумента." +
                                  "\n Аргумент 1 должен содержать:" +
                                  "\n 1) Режим сортировки. Обязательный к указанию. Принимаемые парметры : '-d' = сортировка по возрастанию '-a' = сортировка по убыванию" +
                                  "\nПрочитайте инструкцию и перезапустите программу, указав верное значение аргументов\n");
                            ShowManual();
                            flag = false;
                            break;
                    }
                }
                //Вызов инструкции для корректного запуска программы 
                void ShowManual()
                {
                    Console.WriteLine("Добрый день! Сразу к делу! \nДля корректного запуска программы неободимо ввести верную последовательность аругментов " +
                                      "\n 1) Тип сортировки (Обязательный аргумент). \nУказываемые парметры: \n '-d' - сотрировка по возрастанию. \n '-a' - сортировка по убыванию " +
                                    "\n2) Тип сортируемых данных (Обязательный аргумент). \nУказываемые параметры: \n '-s' - тип string. \n '-i' - тип int." +

                                    "\n3) Имя выходного файла. Если имя не будет указано, то файл будет создан автоматически и будет ему имя 'output.txt' " +
                                    "\n4) Имя вхожного файла 1. Имя файла должно быть 'inpit1.txt'" +
                                    "\n5)  Имя вхожного файла 1. Имя файла должно быть 'inpit2.txt'"
                                      ) ;
                }
                           
            }
            //метод который работает с аргументами, если не будет четкого соблюдения, то напишет ошибку. Также если все хорошо, то будет отражен конечный результат 
            void Condition1Args(string arg0, string[] args)
            {
                try
                {
                    if (args[1] == "-s")
                    {
                        if (args[3] == "input1.txt" && args[4] == "input2.txt")
                        {
                            if (arg0 == "-d")
                            {
                                resultSortString = EndResultString.Sort(inputStringCollectionString.GetString(userInput[3], userInput[4]));
                                File.WriteAllLines(userInput[2], resultSortString);
                                Console.WriteLine($"Данные успешно записаны в файл: {userInput[2]}");
                                flag = false;

                            }
                            else
                            {
                                resultSortString = EndResultString.Sort(inputStringCollectionString.GetString(userInput[3], userInput[4]));
                                resultSortString.Reverse(); // переворачиваем содержимое из-за того что пользователь ввел аргумент -а
                                File.WriteAllLines(userInput[2], resultSortString);
                                Console.WriteLine($"Данные успешно записаны в файл: {userInput[2]}");
                                flag = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный аргумент 4 или 5. \nПерезапустите программу только с одним аргументом '-help' чтобы прочитать инструкцию по запуску.Вероятно указанные входные файлы не найдены");
                            flag = false;
                        }


                    }
                    else if (args[1] == "-i")
                    {
                        
                        
                        if (args[3] == "input1.txt" && args[4] == "input2.txt")
                            {
                             if (arg0 == "-d")
                                {
                                    resultSort = EndResultInt.Sort(inputIntCollection.GetInt(userInput[3], userInput[4]));
                                    File.WriteAllLines(userInput[2], ConvertToString(resultSort));
                                    Console.WriteLine($"Данные успешно записаны в файл: {userInput[2]}");

                                    flag = false;
                             }
                             else
                                {
                                    resultSort = EndResultInt.Sort(inputIntCollection.GetInt(userInput[3], userInput[4]));
                                    resultSort.Reverse();// переворачиваем содержимое из-за того что пользователь ввел аргумент -а
                                    File.WriteAllLines(userInput[2], ConvertToString(resultSort));
                                    Console.WriteLine($"Данные успешно записаны в файл: {userInput[2]}");
                                    flag = false;
                             }
                            }
                        else
                            {
                                Console.WriteLine("Неверный аргумент 4 или 5. Перезапустите программу только с одним аргументом '-help' чтобы прочитать инструкцию по запуску.Вероятно указанные входные файлы не найдены");
                                flag = false;
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Неверный аргумент 2. Перезапустите программу только с одним аргументом '-help' чтобы прочитать инструкцию по запуску.");
                        flag = false;
                    }
                    
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"Вызвано исключение: {ex.Message}. \nВ одном из входных файлов присутствует неверный тип данных. Проверьте входные файлы на однородность типов данных и перезапустите программу!");
                    flag = false;
                }

            }
            
          // метод конверитрует все символы в в строки из-за особенностей метода File.AllWriteLines.
            List<string> ConvertToString(List<int> items)
            {
                List<string> result1 = new List<string>();
                for (int j = 0; j < items.Count; j++)
                {
                    result1.Add(items[j].ToString());
                }
                return result1;
            }
        }
    }
}
