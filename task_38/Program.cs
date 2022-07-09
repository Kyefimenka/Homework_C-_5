// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[10];
int index = 0;
while(index < array.Length)
{
    array[index] = Math.Round(new Random().NextDouble(), 2);
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}]");
//Console.WriteLine(array.Max() - array.Min());

double minNumber = array[0];
double maxNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if(array[i] < minNumber)
    {
        minNumber = array[i];
    }
    if(array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
}
Console.WriteLine(maxNumber - minNumber); 