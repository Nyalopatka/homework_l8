int[,] Array(int xsize,int ysize,int min,int max)

{
    Console.Clear();
    int [,] array = new int[xsize,ysize];
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(min,max+1);
            
        }
        
    }
return array;

}
int[,]Show(int[,]array)
{
    
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1);j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
return array;
}
int[,]Umnozhenie(int[,]matr1,int[,]matr2)
{
     int[,]matRes = new int[matr1.GetLength(0),matr1.GetLength(1)];
     for(int i = 0;i<matr1.GetLength(0);i++)
     {
        for(int j = 0;j<matr2.GetLength(1);j++)
        {
            for(int k = 0;k<matr1.GetLength(0);k++)
            {
                matRes[i,j] += matr1[i,k] * matr2[k,j];
            }
        }
     }
     return matRes;
}
/*int[,]arr1 = {
            {2,4},
            {3,4}
            };
int[,]arr2 = {                          
            {3,2},
            {3,3}
            };
*/
int[,]arr1 = Array(2,2,1,10);
int[,]arr2 = Array(2,2,1,10);
Show(arr1);
Show(arr2);
int[,]res = Umnozhenie(arr1,arr2);
Show(res);



