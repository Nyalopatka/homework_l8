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

void Slovar(int [,]array,int min,int max)
{
    while(min<max)
    {   
        int count = 0;
        for(int i = 0;i<array.GetLength(0);i++)
        {
            for(int j = 0;j<array.GetLength(1);j++)
            {
                if(min == array[i,j]) count++;
            }
        }
         if(count > 0)Console.WriteLine($"число {min} встречается {count} раз.");
         min++;
    }    

}


Console.Write("введите кол-во строк: ");
int xsize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int ysize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение в таблице: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение в таблице: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = Array1(xsize,ysize,min,max);
Show(array);
Slovar(array,min,max+1);

