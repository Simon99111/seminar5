//Исправлены методы CreateArray и FillArray

int[] CreateArray(int size)
 {
    return new int [size];
 }

void FillArray (int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++) 
    {
        randomArray[i] = new Random().Next(-9,9);
        Console.Write(randomArray[i] + " ");
    }
}

int[] array = CreateArray(12);
FillArray(array);


