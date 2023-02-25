// Найти сумму положительных элементов массива
// int FindSumPositiveElementsIn(int[] array)

int SummPositive (int [] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i<length; i++)
        {
            if (array[i] > 0) result = result + array [i] ;
        }
    return result;
}