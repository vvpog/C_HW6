// Задача 41 (вариант): 
// Пользователь вводит с клавиатуры произвольное кол-во чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PrintPositiveCount()
{
Console.WriteLine ("Введите произвольные целые числа через пробел. ");
Console.WriteLine ("Для завершения ввода нажмите Enter :");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

 int count = 0; // Подсчет положительных значений в массиве
  for (int i = 0; i < array.Length; i++)
 {
   if (array[i] > 0)  count++;
 }
Console.WriteLine($"Положительных чисел в массиве: {count}");
Console.Write("  ");
return;
}
PrintPositiveCount();