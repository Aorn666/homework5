// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
// если K – положительное и влево, если отрицательное.

void Filling(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10);
}

//Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] shift = new int[n];
Filling(array);
Console.Write("Введите сдвиг массива: ");
int s = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");

if (s>0)
{
  for (int i =0; i < s ; i++)
  {
    shift[i]=array[n-s+i];
  }
  for (int i =0; i < n-s ; i++)
  {
    shift[s+i]=array[i];
  }
  Console.WriteLine($"сдвитутый массив: [{string.Join(", ", shift)}]");
}
else
{
    s=s*(-1);
    for (int i =0; i < s ; i++)
  {
    shift[n-s+i]=array[i];
  }
  for (int i =0; i < n-s ; i++)
  {
    shift[i]=array[s+i];
  }
  Console.WriteLine($"сдвитутый массив: [{string.Join(", ", shift)}]");
}
    







