// 

Console.Write("Введите длину массива - ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] str = CreateArrayString(arrayLength);
System.Console.Write("Исходный массив: ");
PrintArray(str);
System.Console.WriteLine();
string[] newStr = NewArray(str);
System.Console.Write("Новый массив: ");
PrintArray(newStr);
Console.ReadKey();



void PrintArray(string[] array)
{
    for(int i = 0;i<array.Length;i++)
    {
        System.Console.Write($"\"{array[i]}\" ");
    }
    
}
