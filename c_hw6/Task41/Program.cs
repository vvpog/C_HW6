// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Task41()
{ 
Console.WriteLine("   ");
Console.Write("Введите количество чисел, которые вы будете задавать для сравнения:  ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n]; // Ввод одномерного массива с клавиатуры
    for (int i = 0; i < n; i++)
 {
   array[i] =  Convert.ToInt32(Console.ReadLine());
 }
 

void PrintArray(int[] arr) // красивая печать строки
{
     Console.WriteLine("  ");
     Console.Write(" [ ");
    for (int i = 0; i < n; i++)
    {
        if (i!=arr.Length-1) Console.Write($"{arr[i]},  ");
        else Console.WriteLine($"{arr[i]} ]");
    }
    
}
PrintArray(array);

int count = 0;
  for (int i = 0; i < n; i++)
 {
   if (array[i] > 0)  count++;
 }
Console.WriteLine($"Положительных чисел в массиве: {count}");
Console.Write("  ");
return;
}

Task41();