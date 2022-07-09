// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[10];
int index = 0;
while(index < array.Length)
{
    array[index] = new Random().Next(100, 1000);
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);