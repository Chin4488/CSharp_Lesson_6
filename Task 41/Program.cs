// Задача 41: Пользователь вводит с клавиатуры или задает 
// самостоятельно M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

Console.WriteLine("Укажите какое количество чисел будет использоваться?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int l=0;
for (int i=0; i<size; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) l=l+1;
} 
Console.WriteLine($"Больше 0 введено {l} чисел");