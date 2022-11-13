/* Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number*number);

// Найти являетсо первое число квадратом второго числа
Console.WriteLine("Введите число 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat = number2 * number2;
if (kvadrat == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// Выдать день недели согласно номеру
Console.WriteLine("Напишите цифру дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
    Console.WriteLine("Понедельник");
else
if (num1 == 2)
    Console.WriteLine("Вторник");
else
if (num1 == 3)
    Console.WriteLine("Среда");
else
if (num1 == 4)
    Console.WriteLine("Четверг");
else
if (num1 == 5)
    Console.WriteLine("Пятница");
else
if (num1 == 6)
    Console.WriteLine("Суббота");
else
if (num1 == 7)
    Console.WriteLine("Воскресенье");
else
    Console.WriteLine("Неверная цифра");
    
// ВТОРОЙ ВАРИАНТ Выдать день недели согласно номеру
Console.WriteLine("Week days");
string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Fridey", "Saturda", "Sunday" };
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Today is {Days[index -1]}");

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
int number = int.Parse(Console.ReadLine());
int negativNumber = number * -1;
for (int i = negativNumber; i<= number; i++)
{
    Console.WriteLine(i);
}
*/
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Напишите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100 && num <= 1000)
{
    Console.WriteLine(num % 10);
}
else
    Console.WriteLine("Число не трехзначное");
// Код в одну строку, но без защиты от дурака
//Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 10);