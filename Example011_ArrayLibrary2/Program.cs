void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
int count = col.Length; 
int position = 0;
while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}
}

int IndexOf(int[] collection, int find) 
{
   int count = collection.Length;
   int index = 0;
   int position = -1;
   //можно поставить int position = 0; но лучше -1 это искусственный прием, позволяющий понять, что элемента в массиве нет;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
            //break чтобы искать только первую позицию
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
//int pos = IndexOf(array, 90) так как элемента нет, в этом случае появится -1 в ответе;
Console.WriteLine(pos);