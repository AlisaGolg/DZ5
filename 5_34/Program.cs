/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int []array=new int[8];
int count=0;
for (int n=0; n<8; n++) 
    array[n]=new Random().Next(100,1000);
Console.WriteLine("[" +string.Join(',' , array)+ "]");  
if (array[n]%2==0)
    count++;
    Console.WriteLine(count);


