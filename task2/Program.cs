// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100){
    Console.WriteLine("Третьего числа нет");
}
else {
    int third_num = (num/100)%10;
    Console.WriteLine($"Для числа {num} третье число {third_num}");
}

