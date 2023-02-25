
int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[]array)
{
    int[] randomArray = new int[12];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = new Random().Next(-9,9);
                Console.Write(randomArray[i] + " ");
    }
}

int[]array = CreateArray(12);
FillArray(array);

// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

// Создание массива - Ольга
// Заполнение случайными числами от [-9 , 9] - Ольга
// Вывод массива - Семён
// Нахождение суммы положительных чисел массива - Антон
// Нахождение суммы отрицательных чисел - Семён

void PrintArray (int [] array)
{
    int length = array.Length;
    for (int i = 0; i<length; i++)
    {
        Console.Write(array[i]+" ");
    }
Console.WriteLine();
}

int SummNegative (int [] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i<length; i++)
        {
            if (array[i]<0) result = result + array [i] ;
        }
    return result;
}

