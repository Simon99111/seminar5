// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

// Создание массива - Ольга
// Заполнение случайными числами от [-9 , 9] - Ольга
// Вывод массива - Семён
// Нахождение суммы положительных чисел массива - Антон
// Нахождение суммы отрицательных чисел - Семён

int[] CreateArray(int size) //Создание массива - Ольга
{
    return new int[size];
}

int [] FillArray(int[]array) //Заполнение массива - Ольга
{
    int[] randomArray = new int[12];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = new Random().Next(-9,9);
        }
    return randomArray;
}

void PrintArray (int [] array) //Вывод массива - Семён
{
    int length = array.Length;
    for (int i = 0; i<length; i++)
    {
        Console.Write(array[i]+" ");
    }
Console.WriteLine();
}

int SummPositive(int [] array) //Находение суммы положительных элементов - Антон

{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i<length; i++)
        {
            if (array[i] > 0) result = result + array [i] ;
        }
    return result;
}

int SummNegative (int [] array) //Находение суммы отрицательных элементов - Семён
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i<length; i++)
        {
            if (array[i] < 0) result = result + array [i] ;
        }
    return result;
}


int[] array = CreateArray(12);
int[] c = FillArray(array);
Console.WriteLine();
PrintArray(c);
int summPos = SummPositive(c);
int summNeg = SummNegative(c);
Console.WriteLine(summPos);
Console.WriteLine(summNeg);
