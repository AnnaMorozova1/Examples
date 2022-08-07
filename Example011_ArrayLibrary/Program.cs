void FillArray (int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int posotion = 0;
    while (posotion < count)
    {
        Console.WriteLine(col[posotion]);
        posotion++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=-1;
    while (index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}


int[] array=new int[10];
FillArray(array);
array[5]=4;
array[2]=4;
PrintArray(array);
Console.WriteLine();

int pos=IndexOf(array, 4);
Console.WriteLine(pos);

