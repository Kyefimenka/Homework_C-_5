// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
int index = 0;
while(index < array.Length)
{
    array[index] = new Random().Next(1, 10);
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}]");
int sumUneven = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sumUneven += array[i];
}
Console.WriteLine(sumUneven);
