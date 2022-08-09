    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class FourByFourMatrice
    {
        public int GetDeterminant(int[,] M)
        {

            int determinant;
            if (M.GetLength(0) == 4 && M.GetLength(1) == 4)
            {
                determinant = M[0, 0] * (M[1, 1] * ((M[2, 2] * M[3, 3]) - (M[3, 2] * M[2, 3])) - M[1, 2] * ((M[2, 1] * M[3, 3]) - (M[3, 1] * M[2, 3])) + M[1, 3] * ((M[2, 1] * M[3, 2]) - (M[3, 1] * M[2, 2])))
                            - M[0, 1] * (M[1, 0] * ((M[2, 2] * M[3, 3]) - (M[3, 2] * M[2, 3])) - M[1, 2] * ((M[2, 0] * M[3, 3]) - (M[3, 0] * M[2, 3])) + M[1, 3] * ((M[2, 0] * M[3, 2]) - (M[3, 0] * M[2, 2])))
                            + M[0, 2] * (M[1, 0] * ((M[2, 1] * M[3, 3]) - (M[3, 1] * M[2, 3])) - M[1, 1] * ((M[2, 0] * M[3, 3]) - (M[3, 0] * M[2, 3])) + M[1, 3] * ((M[2, 0] * M[3, 1]) - (M[3, 0] * M[2, 1])))
                            - M[0, 3] * (M[1, 0] * ((M[2, 1] * M[3, 2]) - (M[3, 1] * M[2, 2])) - M[1, 1] * ((M[2, 0] * M[3, 2]) - (M[3, 0] * M[2, 2])) + M[1, 2] * ((M[2, 0] * M[3, 1]) - (M[3, 0] * M[2, 1])));
            }
            else
            {
                determinant = 0;
            }
            return determinant;
        }
    }
}
