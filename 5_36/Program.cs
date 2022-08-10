/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(-99, 100);
}
Console.WriteLine("[" +string.Join(", ", array)+ "]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: = {array[0]+array[2]}");

