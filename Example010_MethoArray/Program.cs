int[] array = { 6, 7, 3, 89, 35, 65, 3, 5 };
int n = array.Length;

int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}