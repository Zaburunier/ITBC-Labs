using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLibrary_Lab5
{
    public class Levenshtein
    {
        public static int Distance(string s1, string s2)
        {
            string str1 = s1;
            string str2 = s2;
            if ((str1 == null) || (str2 == null)) return -1;

            int lengthStr1 = str1.Length;
            int lengthStr2 = str2.Length;

            if ((lengthStr1 == 0) && (lengthStr2 == 0)) return 0; //Для двух нулевых строк расстояние равно нулю, для одной нулевой расстояние равняется длине другой строки
            if (lengthStr1 == 0) return lengthStr2;
            if (lengthStr2 == 0) return lengthStr1;

            string string1 = str1.ToUpper(); //Приведение к регистру для исключения одинаковых символов
            string string2 = str2.ToUpper();
            int[,] distanceMatrix = new int[lengthStr1 + 1, lengthStr2 + 1];
            for (int i = 0; i <= lengthStr1; i++) //Часть значений элементов матрицы известна до применения алгоритма
                distanceMatrix[i, 0] = i;
            for (int j = 0; j <= lengthStr2; j++)
                distanceMatrix[0, j] = j;

            //Алгоритмическая часть
            for (int i = 1; i <= lengthStr1; i++)
            {
                for (int j = 1; j <= lengthStr2; j++)
                {
                    int equalityM = (string1.Substring(i - 1, 1) != string2.Substring(j - 1, 1)) ? 1 : 0; // m(a, b) = 0 <=> a == b; m(a, b) = 1 <=> a =/= b
                    int additionI = distanceMatrix[i, j - 1] + 1; //Операция добавления
                    int removalD = distanceMatrix[i - 1, j] + 1; //Операция удаления
                    int substituionR = distanceMatrix[i - 1, j - 1] + equalityM; //Операция замены
                    distanceMatrix[i, j] = Math.Min(Math.Min(additionI, removalD), substituionR);
                }
            }

            return distanceMatrix[lengthStr1, lengthStr2];
        }

    }
}
