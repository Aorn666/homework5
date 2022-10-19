// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Filling(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);
}

int Find(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count++; 
}
return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Filling(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.Write(Find(array));