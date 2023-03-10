/* Задача 52. 

               Например, задан массив:
                       1 4 7 2
                       5 9 2 3
                       8 4 2 4
             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] GetMatrix  (int rows, int cols, int minValue, int maxValue)
{
        int [,] matrix = new int[rows,cols];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
              for (int j = 0; j < cols; j++)
              {
                     matrix[i,j] = new Random().Next(minValue,maxValue+1);       
              }
        }
        return matrix;      
}
void PrintMatrix(int[,] matr)
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
double []  ArithmeticAverage  (int[,] inputArray)
{ 
  double [] outputArray = new double[inputArray.GetLength(1)];       
    
  for (int j = 0; j < inputArray.GetLength(1); j++) 
  {   
        double sum = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
         sum += inputArray[i,j];
        }     
  outputArray[j] = Math.Round(sum/inputArray.GetLength(0),2); 
  } 
  return outputArray;
}     
int [,] resultMatrix =  GetMatrix(3,4,0,10);
PrintMatrix(resultMatrix);   
double [] elementArray = ArithmeticAverage (resultMatrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(" ; ",elementArray)}");