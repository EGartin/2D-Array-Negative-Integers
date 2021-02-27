/* 
* Project: 2D-Array-Negative-Integers
* Author: Elijah Gartin 
* Date: 2020 FEB 26
* Contact: elijah.gartin@gmail.com
*/

using System;

namespace _2D_Array_Negative_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] CEarray =
            {
                {-4,-3,-1,1},
                {-2,-2,1,2},
                {-1,1,2,3},
                {1,2,4,5}
            };/*End Array Init*/
            
            /*Call Function and Pass Array to find Negative Numbers*/
            FindNegatives2DArray(CEarray);

        }/*End Main Block*/

        static void FindNegatives2DArray(int [,] array){            
            
            int eval = 0;
            int negativeTotal = 0;

            System.Console.Write("Negative numbers in Array: ");
            
            /*Parse Array with nested for loops to read each column in a row and move on to the next row*/
            
            /*Row For Loop*/
            for (int i = 0; i < array.GetLength(0); i++)
            {            
                /*Column For Loop*/       
                for (int j=0;j < array.GetLength(1); j++)
                {
                    eval = array[i,j];
                    
                    if (eval < 0){
                        System.Console.Write(eval + ", ");
                        negativeTotal++;
                    }
                }/*End Column for Loop*/

            }/*End Row for loop*/

            System.Console.WriteLine("");
            System.Console.WriteLine("There are " + negativeTotal + " negative numbers in the Array.");

        }/*End FindNegatives2DArray Function */
    }/*End Class Block*/
}/*End Namespace Block*/
