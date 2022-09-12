// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
void Point()
{
float x = 0 ; float y = 0;
Console.WriteLine("   ");
Console.WriteLine("Для двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;  ");
Console.WriteLine( " Введите коэффиценты k1 и b1 через пробел, для ввода нажмите Enter ");
float[] array1 = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
Console.WriteLine( " Введите коэффиценты k2 и b2 через пробел, для ввода нажмите Enter ");
float[] array2 = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

if (array1[0]==array2[0] && array1[1] != array2[1] ) 
    {
     Console.WriteLine(" Эти прямые не пересекаются");
    }

else 
    {
     if (array1[0]==array2[0] && array1[1]==array2[1]) Console.WriteLine(" Эти прямые совпадают");
     else 
        {
         x = (array2[1]-array1[1])/(array1[0]-array2[0]); 
         y = (array1[0]*array2[1]-array1[1]*array2[0])/(array1[0]-array2[0]); 
         Console.WriteLine($" Точка пересечения этих прямых имеет координаты: ( {x}, {y} )" );
        } 
    }
return;
}
Point();