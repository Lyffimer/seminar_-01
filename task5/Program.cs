﻿Console.WriteLine("Введите первое число N ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}