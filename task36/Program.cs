// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int size = 6;
int sum =0;
int [] array = new int [size];
int [] newarr = new int [size];
void Fill (int [] fill)
{
    for (int i = 0;i<fill.Length; i++)
    {
        fill[i] = new Random().Next(-10,10);
    }
}
Fill (array);
Console.WriteLine(string.Join(",",array));

void Count (int [] crox)
{
for (int i =1;i< crox.Length ;i = i+2)
{
crox[i] = array[i];
}
}

Count(newarr);

foreach (int el in newarr)
{
  sum = el + sum;
}
Console.WriteLine("сумма элементов на нечётных позициях в массиве => " + sum );