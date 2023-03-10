/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
              в двумерном массиве, и возвращает значение этого элемента или же 
              указание, что такого элемента нет.

                     Например, задан массив:

                               1 4 7 2

                               5 9 2 3

                               8 4 2 4

         1(строчка) 7 (столбец) -> такого числа в массиве нет*/

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
void PositionElement ( int rows, int cols,int[,] inputArray)
{
           if (rows < inputArray.GetLength(0) && cols < inputArray.GetLength(1)) 
           { 
             Console.Write($"Элемент {rows} строки {cols} столбца равен {inputArray[rows,cols]}");
           }             
           else  Console.Write("Элемента с такой позицией нет");
}  
int [,] resultMatrix =  GetMatrix(3,4,0,10);
PrintMatrix(resultMatrix);
Console.Write("Введите номер строки для элемента в массиве: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для элемента в массиве: ");
int j = Convert.ToInt32(Console.ReadLine());
PositionElement(i,j,resultMatrix);