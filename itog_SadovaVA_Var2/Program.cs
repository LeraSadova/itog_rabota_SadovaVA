Console.Clear(); // очищаем терминал при запуске
Console.WriteLine("Привет, друг! Давай создадим текстовый одномерный массив?");
Console.WriteLine("Сначала определим, сколько слов с клавиатуры мы введем. Укажи число слов:");
Console.WriteLine("ps: лучше введите небольшое число, чтобы не заполнять много букв ;)");
int n=Convert.ToInt32(Console.ReadLine()); // n-это число слов в текстовом массиве

string[] array1 = new string[n]; // объявляем наш массив, теперь будем его заполнять:
int i=0;

while (i<n)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива"); //вводим элементы массива с клавиатуры
    array1[i]=Console.ReadLine();
    //Console.WriteLine();
    i++;
}
//выводим массив на экран:
Console.WriteLine("Введенный с клавиатуры массив имеет вид: ");
for (i = 0; i < n; i = i + 1)
Console.Write($"[{array1[i]}]");

void PrintArray(string[] array) //метод для печати нужных нам элементов массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        Console.Write($"{array[i]} ");
        
    }
    
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("элементы массива, удовлетворяющие условию задачи:");
PrintArray(array1); // выводим результат метода на печать
