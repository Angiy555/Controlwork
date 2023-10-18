// Контрольная работа
/*Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше, либо 
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
массивами.*/
string[] array = {"Sveta", "I", "Two","My", "Ferst","Second"};
Console.Clear();
PrintArray(array);
Console.WriteLine();
PrintArray(TransformArray(array));


//Печатаем массив
void PrintArray (string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {        
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
//Преобразование массива с данными меньше, либо равна 3 символам
string[] TransformArray (string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3)
        {
            count ++;
        }
    }
    string[] res = new string[count];
    int j = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3)
        {
            res[j] = array[i];
            j++;
        }
    }
    return res;
}