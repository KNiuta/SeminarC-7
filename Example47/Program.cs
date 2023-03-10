/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
              вещественными числами.

                   m = 3, n = 4.

                   0,5 7 -2 -0,2

                   1 -3,3 8 -9,9

                   8 7,8 -7,1 9 */

double [,] GetMatrix  (int rows, int cols, int minValue, int maxValue)
{
        double [,] matrix = new double[rows,cols]; 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
              for (int j = 0; j < cols; j++)
              {
                     matrix[i,j] = Convert.ToDouble(new Random().Next(minValue,maxValue+1)/10.0);        
              }
        }
        return matrix;      
}              
void PrintMatrix(double[,] matr)
{
      for (int i = 0; i < matr.GetLength(0); i++)
      {
             for (int j = 0; j < matr.GetLength(1); j++)
             {
               Console.Write(matr[i,j]+"\t");
             } 
            Console.WriteLine(); 
      }        
}
double [,] resultMatrix =  GetMatrix(3,4,-100,100);
PrintMatrix(resultMatrix);