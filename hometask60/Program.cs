int[,,] Array1(int xsize,int ysize,int zsize,int min,int max)
{
    Console.Clear();
    int [,,] array = new int[xsize,ysize,zsize];
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1);j++)
        {
            for(int z = 0;z<array.GetLength(2);z++)
            {
                int x = new Random().Next(min,max+1);
                array[i,j,z] = x;
            }
            
        }
        
    }
return array;
}

int[,,]Show(int[,,]array)
{
    
    for(int z = 0;z < array.GetLength(0);z++)
    {
        for(int i = 0;i < array.GetLength(1);i++)
        {
            for(int j = 0;j<array.GetLength(2);j++)
            {
            Console.Write($" {array[i,j,z]}  ({i},  {j},  {z})");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
return array;
}

int[,,] array = Array1(2,2,2,10,99);
Show(array);

