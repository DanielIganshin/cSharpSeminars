// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 == number2 * number2 )
// {
//     Console.WriteLine($"Квадрат числа {number2} равен {number1} ");
// }
// else Console.WriteLine("Квадрат числа {0} не равен {1} ", number2, number1);

// string word = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine(word);

// int number = Convert.ToInt32(Console.ReadLine());
// int notNumber = -number;

// while(notNumber <= number) 
// {
//     Console.Write($"{notNumber} ");
//     notNumber++; //notNumber + 1

// }

int number = Convert.ToInt32(Console.ReadLine());
int first = number%10;
int second = number/10%10;
int third = number/100;
int sum = first + third;
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
Console.WriteLine(sum);