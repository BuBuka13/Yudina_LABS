//1. Получение от пользователя числа
//2. Мат операции с числом
//3. Создание массива размерностью этого числа и заполнение его случайными данными.
//4. Вывод массива в консоль
Random rand = new Random();
Console.Write("Введите целое число:");

try
{
    
    // 1
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number);

    //2
    Console.WriteLine(number*13);
    Console.WriteLine(Math.Pow(number, 3));

    //3 and 4
    Console.WriteLine("Массив");
    number = Math.Abs(number);
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = rand.Next(-100,100);
        Console.WriteLine(array[i]);

    }
}

catch (Exception ex)
{
    Console.WriteLine("Введите ЧИСЛО!");
    Console.WriteLine(ex.Message);
}


