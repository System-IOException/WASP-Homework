﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B3.
    // Кол-во стингеров: ½🔹
    //
    // Написать функцию Decrypt(string key), которая подсчитывает количество вхождений символов с 'a' до 'z' и 
    // возвращает строку длиной 26 символов, где на каждой позиции - количетво вхождений этой буквы в строке. 
    // Буквы должны быть упорядочены, как в алфавите.
    //
    // Примеры:
    // decrypt('$aaaa#bbb*cc^fff!z') ==> '43200300000000000000000001'
    //           ^    ^   ^  ^  ^         ^^^  ^                   ^
    //          [4]  [3] [2][3][1]        abc  f                   z
    public static class TaskB3
    {
        public static string Decrypt(string key)
        {
            // Здесь необходимо написать код.
            Dictionary<char, int> toRet = new Dictionary<char, int>();
            for (int i = 'a'; i < 'z' + 1; i++)
            {
                toRet.Add((char)i, 0);
            }
            foreach (char c in key)
            {
                if (toRet.ContainsKey(c)) toRet[c]++;
            }
            string answer = "";
            foreach (var c in toRet)
            {
                answer += c.Value;
            }
            return answer;
        }
    }
}
