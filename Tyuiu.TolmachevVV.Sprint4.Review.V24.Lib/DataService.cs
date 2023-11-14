using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TolmachevVV.Sprint4.Review.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int str_iter = 0;
            int mult = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[str_iter].ToString());
                    str_iter++;
                    if (matrix[i, j] % 2 == 0)
                    {
                        mult *= matrix[i, j];
                    }
                }
            }
            return mult;
        }
    }
}
