﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B1.
    // Кол-во стингеров: ½🔹
    //
    // Написать функцию MeanSquare(List<int> list1, List<int> list2),
    // которая получает два целочисленных списка одинаковой длины,
    // сравнивает значение каждого члена в одном списке с соответствующим
    // элементом в другом, возводит в квадрат разницу абсолютных значений
    // между этими двумя значениями и возвращает среднее значение квадратов
    // каждой парой элементов. 
    //
    // Пример:
    // MeanSquare([0, -1], [-1, 0]) ==> 1 --> ( (0-(-1))^2 + (-1-0)^2 ) / 2 = 1
    public static class TaskB1
    {
        public static double MeanSquare(List<int> list1, List<int> list2)
        {
            // Здесь необходимо написать код.
            int sum = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                int v = list1[i] - list2[i];
                sum += v * v;
            }
            return sum * 1.0 / list1.Count;
        }
    }
}
