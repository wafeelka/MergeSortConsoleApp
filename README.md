# MergeSortConsoleApp
 This app takes data from two format files and sorts them into one output file. The sorting algorithm is merge sort.
You have to start this app from command line on Windows and  write some arguments.

In russian language:

MergeSortApp - это программа,которая принимает файлы формата .txt, 
сортирует их содержимое при помощи метода "соритровка слиянием" 
и записывает объединенный результат соритровки в новый файл формата txt.

---------------------------------------------------------------------------------------

Текущая версия приложения работает со следующими особенностями:
1) Кол-во аргументов должно быть 5. Все аргументы обязательны к написанию. 
	Порядок:
	1. Тип сортировки ( '-d' по возрастанию; '-a' по убыванию);
	2. Тип данных во входных файлах ('-s' строки '-i' целые числа);
	3) Имя выходного файла. Любое название.
	4) Имя первого входного файла. Файл ОБЯЗАТЕЛЬНО должен называться 'input1.txt'; 
	5) Имя второго входного файла. Файл ОБЯЗАТЕЛЬНО должен называться 'input1.txt'; 
2)Кол-во входных файлов для сортировки 2. Данное кол-во не может быть изменено. 
4) Несоблюдение порядка вводимых аргументов при запуске программы повлечет за собой остановку программы с описанием ошибки. Для получения информации о том, как верно запустить программу, запустите приложение только с аргументом  '-help'.
5) Сортировка корректно проводится, только с типами данных string, int;

Пример ввода в cmd для успешного запуска: 
1 команда: cd C:\Users\user\Desktop\MergeSort\MergeSortApp\bin\Debug\

2 команда: MergeSortApp.exe -d -i  output.txt input1.txt input2.txt
---------------------------------------------------------------------------------------

Желаем Вам приятной работы!


Предлагаем Вам также ознакомиться с ошибками, о которых мы уже знаем:
1) Дублирующий код. 
2) Несоблюдение приципа SRP. Класс ArgsReading отвечает за несколько функций, а должен за одну. 
3) Сложно читать ветвления.
4) Сильнозависимая архитектура программы.

Если Вы не увидели Ваше замечание/пожелание в этом списке, то просим Вас написать о нём на почту : adeevartem@yandex.ru
