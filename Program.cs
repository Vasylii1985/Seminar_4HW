﻿
// Задать массив из 8 элементов и вывести их на экран

int [] array = new int [8];


    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

PrintArray(array);