int[,] Array1(int xsize,int ysize,int min,int max)

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
int [,] Change(int[,]array,int max)
{
for(int i = 0;i<array.GetLength(0);i++)
{
    int[]array2 = new int[array.GetLength(1)];
    for(int j = 0; j< array.GetLength(1);j++)
    {
        array2[j] = array[i,j] ;
        
    }
    Array.Sort(array2);
    Array.Reverse(array2);
    for(int x = 0;x<array2.Length;x++)
    {
        array[i,x] = array2[x];
    }
}
return array;
}


Console.Write("введите кол-во строк: ");
int xsize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int ysize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение в таблице: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение в таблице: ");
int max = Convert.ToInt32(Console.ReadLine());
int[]array2 = new int[xsize];
int[,] array = Array1(xsize,ysize,min,max);
Show(array);
int[,] arr = Change(array,min);
Show(arr);