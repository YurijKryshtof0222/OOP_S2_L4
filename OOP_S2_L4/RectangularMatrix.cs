using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_S2_L4
{
    internal class RectangularMatrix
    {
        private int[][] matrix;
        private int rows;
        private int cols;

        public RectangularMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new int[rows][];
            for(int i = 0; i < rows; i++) 
            {
                this.matrix[i] = new int[cols];
            }
        }

        /*public RectangleMatrix(int rows, int cols, int from, int to)
        {
            Random rand = new Random();
            matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(from, to);
                }
            }
        }*/

        public int this[int i, int j]
        {
            get
            {
                if (i < rows && i >= 0 || j < cols && j >= 0)
                    return matrix[i][j];
                else throw new IndexOutOfRangeException();
            }
        }

        public int GetRows() { return rows; }
        public int GetCols() { return cols; }

        public void FillElemnentsRandom(int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i][j] = rand.Next(min, max);
                }
            }
        }

        public int FirstNullNegativesColumn()
        {
            int j = -1;
        SkipColumn:
            while (++j < cols) //Цикл проходу по стовпцям
            {
                for (int i = 0; i < rows; i++) //Цикл проходу по рядкам
                {
                    if (matrix[i][j] < 0)
                        goto SkipColumn; //Якщо у стовпці є від'ємні числа - пропускаєм цей стовпець
                }
                return j; //Якщо стовпець без від'ємних чисел - вертаємо його індекс
            }
            return -1; //Якщо стовпців без від'ємних чисел нема.
        }

        public RectangularMatrix GetSortedMatrix_ByMaxTheSameNumberCount_OfEachRow()
        {
            //Список пар: макс. к-ть повторюваних е-ів на кожен рядок.  
            var maxTheSameNumberCount_OfEachRow = new List<KeyValuePair<int, int>>();
            //Цикл проходу по рядкам
            for (int i = 0; i < rows; i++)
            {
                //Словник у якій пара - число : к-ть їх повторень у рядку(з індексом i)
                var elementCounts = new Dictionary<int, int>();
                //Цикл проходу по стовпцям рядка
                for (int j = 0; j < cols; j++)
                {
                    int elem = matrix[i][j];
                    if (!elementCounts.ContainsKey(elem)) // Якщо ключ - число не існує
                        elementCounts.Add(elem, 1); // створоюєм його у слонвику
                    else
                        elementCounts[elem]++; //інкаше прибаваляємо значення на 1 більше по ключу
                }
                int maxElemCount = elementCounts.Aggregate(
                    (x, y) => x.Value > y.Value ? x : y).Value; //вибираєм найб. к-ть повторень числа на рядок
                maxTheSameNumberCount_OfEachRow.Add(new KeyValuePair<int, int>(maxElemCount, i)); //всталяєм пару
            }
            maxTheSameNumberCount_OfEachRow.Sort((x, y) => x.Key.CompareTo(y.Key)); //Сортуєм по к-ті повторень числа на рядок
            RectangularMatrix newMatrix = new RectangularMatrix(rows, cols); //нова матриця
            int dstRowIndex = 0;
            foreach (var entry in maxTheSameNumberCount_OfEachRow)
            {
                int srcRowIndex = entry.Value;
                newMatrix.matrix[dstRowIndex++] = this.matrix[srcRowIndex];
            }
            return newMatrix; //Вертаємо посортовану відповідним чином матрцию
        }

    }

}