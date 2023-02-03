// адача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2    //1, -7, 567, 89, 223-> 3

Console.Clear();

    Console.WriteLine("Введите количество элементов массива:  ");
    int massivCount = int.Parse(Console.ReadLine()!);
    int[]array=new int[massivCount];
    int lenght=array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Введите элемент массива с индексом {i}:  ");
        array[i]= int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine(array[i]);
    }
  int positivCount(int[]array)
  {
    int positive=0;
    int xl= array.Length;
    for (int i = 0; i < xl; i++)
    {
       if (array[i]>0)
       {
        positive+=1;
       } 
    }
    return positive;
  } 

int result = positivCount(array);
Console.WriteLine($"Пользователь ввел  {result}  положительных чисел");   
   