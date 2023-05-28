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
void FindSumm(int[,]array1,int[]array2)
{
for(int i = 0;i< array1.GetLength(0);i++)
{
    int summ = 0;
    for(int j = 0;j<array1.GetLength(1);j++)
    {
        summ += array1[i,j];
        
    }
    array2[i] = summ; 
    
}
int minV = 2100000000;
for(int i = 0;i < array2.Length;i++)
{
if (array2[i]< minV)array2[i]= minV;  
}
int count = 0;
for(int i = 0;i<array2.Length;i++)  
    if(array2[i] == minV)
    count++;

Console.WriteLine($"{count-1} строка");
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
int[,] array = Array(xsize,ysize,min,max);
Show(array);
FindSumm(array,array2);