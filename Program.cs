/*Программа из имеющегося массива строк формирует массив из строк, дилна которых меньше либо равна 3 символам. 
Первоначальный массив вводится с клавиатуры.

Например:

["hello","2","world",":-/"] -> ["2",":-/"]
*/

Console.WriteLine("Введите строки через запятую");
string [] strArrayA = Console.ReadLine().Split(',');
for (int i = 0; i < strArrayA.Length; i++)
{
    if (strArrayA[i].Length <=3)
    {
        Console.Write($"{strArrayA[i] }");
    }
}
