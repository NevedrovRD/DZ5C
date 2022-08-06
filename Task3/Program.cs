// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//ПРИШЛОСЬ ЗАДАТЬ ОГРАНИЧЕНИЕ МАССИВУ В СТРОКЕ 12, ТАК КАК СЛИШКОМ ОГРОМНЫЕ ЦИФРЫ

Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double min = array[0];
double max = array[0];
double diff = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 100);
    if (min > array[i])
        min = array[i];
    if (max < array[i])
        max = array[i];
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(min);
Console.WriteLine(max);

    diff = max - min;

Console.WriteLine(diff);
