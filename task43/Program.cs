﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите число b1");
int b1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1");
int k1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2");
int b2=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
int k2=int.Parse(Console.ReadLine()!);

double difb=b2-b1;                     
double difk=k1-k2;
double x =difb/difk;
double y= k2*x+b2;
   
if (difk!=0)
{
    Console.WriteLine($"Прямые пересекаются в точке с координатами({x};{y})"); 
} 
  else
  {
     Console.WriteLine($"Прямые не пересекаются");
  } 
     
