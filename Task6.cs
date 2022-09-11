//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Enter numbers separated by spaces: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for(int i = 0; i < array.Length; ++i)
 {
    if(array[i] > 0)
    {
    count++;
    }
 }
  Console.WriteLine("Number of elements > 0 = " + count);

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
