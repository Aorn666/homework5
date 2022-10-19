// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Filling(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().NextDouble();
}

double Find(double[] array)
{
double a = 0;
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
a=max-min;
return a;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Filling(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.Write(Find(array));