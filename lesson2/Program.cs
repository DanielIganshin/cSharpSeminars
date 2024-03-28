// int num = new Random().Next(100,999);
// Console.WriteLine(num);
// int num_1 = num % 10;
// int num_2 = num / 100;

// Console.WriteLine(num_2 + "" + num_1);
// Console.WriteLine(num_2 * 10 + num_1);

// int result = num_2 * 10 + num_1;
// Console.WriteLine($"{num} -> {result}");

// int result_2 = Convert.ToInt32((num_2 * 10 + num_1));
// Console.WriteLine($"{num} -> {result_2}");

// string num_str = Convert.ToString(num);
// Console.WriteLine(Convert.ToString(num_str[0]) + Convert.ToString(num_str[2]));
// Console.WriteLine(num_str[0] + "" + num_str[2]);

// int num = new Random().Next(100,999);
// Console.WriteLine(num);
// int num1 = num % 100;
// int num2 = num1 / 10;
// int num3 = num1 % 10;
// Console.WriteLine($"num1:{num1}");
// Console.WriteLine($"num2:{num2}");
// Console.WriteLine($"num3:{num3}");
// Console.WriteLine($"результат:{Math.Pow(num2, num3)}");

// int i = 1;
// int c = num2;

// while (i < num3)
// {
//     c *= num2;
//     Console.WriteLine(c);
//     i++;
// }
// функция
// string Test(int first, int second)
// {
// if (second == 0) { return "Деление на 0!"; }

// int res = first % second;

// if (res == 0)
// {
// return "Да";
// }
// else
// {
// return $"Нет, {res}";
// }
// }

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine(Test(num1,num2));


// if (num2 == 0) { Console.WriteLine("Деление на 0!");}
// else
// {
//     int res = num1 % num2;
//     if (res == 0)
//     {
//         Console.WriteLine("Yes");
//     }
//     else
//     {
//         Console.WriteLine($"No, {res}");
//     }
// }

using System;
int num = new Random().Next(0,10000);
Console.WriteLine(num);
int res = 0;
if(num<100) 
{
    Console.WriteLine($"третий цифры нет: {num}");
}
else
{
    while(num>=100 )
    {
        res = num % 10;
        num/=10;// num = num / 10; 
        Console.WriteLine($"num {num}");
        Console.WriteLine($"ответ {res}");
        Console.WriteLine();
    }
}