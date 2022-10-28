// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000){
    int second_num = (num/10)%10;
    Console.WriteLine($"Для числа {num} второе число {second_num}");
}
else Console.WriteLine("Число не трехначное");
