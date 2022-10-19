// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void Filling(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10);
}

int Find(int[] array)
{
int count = 0;
for (int i = 1; i < array.Length; i=i+2)
{

count=count+ array[i]; 
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