/*Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void FillArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=new Random().Next (0,100);
    }
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { 
        if ( i == 0 )
        {
             Console.Write ("["+ arr[i]+", ");
        }
        else if ( i == (arr.Length-1))
        {
            Console.Write ( arr[i] +"]");
        }
    
        else 
        {
            Console.Write ( arr[i] +", ");
        }
    }

}

int [] array = new int [8];
FillArray(array);
PrintArray (array);

