//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 10;
int max = 999;
int min = 100;
int count = 0;
int [] array = new int [size];
void Filler (int [] fill)
{
    for(int i=0;i<fill.Length;i++)
    {
        fill[i] = new Random().Next(min, max+1);
    }
}
Filler (array);
Console.WriteLine(string.Join(",", array));
for ( int j =0;j<array.Length;j++)
{
if (array[j] % 2 == 0)
{
    count++;
}
}
Console.WriteLine("в этом массиве " + count + " чётных чисел");
