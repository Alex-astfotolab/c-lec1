int[] array = { 41, 32, 33, 44, 15, 46, 37, 28 };
int n = array.Length;
int find = 46;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.Write(index);
        break;
    }
    index++;
}
