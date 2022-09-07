// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int size = 6;
double min =0 ;
double max = 0;
double [] array = new double [size];
for (int i = 0; i< array.Length;i++)
{
    array[i] = new Random().Next(10,1000);
}
Console.WriteLine(string.Join(",",array));
for (int j = 0; j< array.Length;j++)
{
    
    if (array[j] > max)
    {
        max = array[j];
    }

}
for (int k = array.Length-1; k>=0;k--)
{
    
    if (array[k] < max)
    {
        min = array[k];
    }

}
double m = max-min;
Console.WriteLine("маскимальное число " + max);
Console.WriteLine(" минимальное число " + min);
Console.WriteLine("Разница между максимальным и минимальным числом в массиве составляет: " + m);