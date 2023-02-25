//Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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





    

