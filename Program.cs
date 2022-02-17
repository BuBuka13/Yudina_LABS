//1. Получение от пользователя числа
//2. Мат операции с числом
//3. Создание массива размерностью этого числа и заполнение его случайными данными.
//4. Вывод массива в консоль


// 1
Console.Write("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

//2
Console.WriteLine(number*13);
Console.WriteLine(Math.Pow(number, 3));

//3 and 4
Console.WriteLine("Массив");
int[] array = new int[number];
Random rand = new Random();
for (int i = 0; i < number; i++)
{
    array[i] = rand.Next(-100,100);
    Console.WriteLine(array[i]);

}
   
