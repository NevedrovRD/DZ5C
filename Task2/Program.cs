// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//ПРИШЛОСЬ ЗАДАТЬ ОГРАНИЧЕНИЕ МАССИВУ В СТРОКЕ 10, ТАК КАК СЛИШКОМ ОГРОМНЫЕ ЦИФРЫ

Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for(int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 100);
    if (i % 2 != 0)
        sum = sum + array[i];    
}

Console.WriteLine(sum);