using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class SparseMatrix<T>
    {
        
        Dictionary<string, T> _matrix = new Dictionary<string, T>();//Хранение значений

        int maxX;
        int maxY;
        int maxZ;//Максимальное число элементов в каждом измерении

        T nullElement;//Базовый элемент, который будет выводиться в консоль на место нулевого

        public SparseMatrix(int x, int y, int z, T nullElementParam)//Конструктор для работы с матрицей
        {
            this.maxX = x;
            this.maxY = y;
            this.maxZ = z;
            this.nullElement = nullElementParam;
        }

        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }

        
        void CheckBounds(int x, int y, int z)//Проверка на выход за границы матрицы при попытке получения доступа к элементу
        {
            if (x < 0 || x >= this.maxX) throw new Exception("Значение " + x + " выходит за границу в измерении X!\n");
            if (y < 0 || y >= this.maxY) throw new Exception("Значение " + y + " выходит за границу в измерении Y!\n");
            if (z < 0 || z >= this.maxZ) throw new Exception("Значение " + z + " выходит за границу в измерении Z!");
        }

       
        string DictKey(int x, int y, int z)//Формирование ключа для словаря
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        
        public override string ToString()//Приведение матрицы в строковый вид
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("Для Z = " + k + ":\n");
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0) b.Append("\t\t");
                        b.Append(this[i, j, k].ToString());
                    }
                    b.Append("]\n");
                }
            }
            return b.ToString();
        }
    }
}
