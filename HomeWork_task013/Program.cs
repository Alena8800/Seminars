// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
//преобразовали текс в число
int number = Convert.ToInt32(Console.ReadLine());
// преобразовали число в строчный вид
string numbertwo = Convert.ToString(number);
if (numbertwo.Length > 2)
{
    // [] третье число в длине массива 
    Console.WriteLine("третья цифра -> " + numbertwo[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}