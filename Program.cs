Console.WriteLine("Введите первое значение");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine("Первое значение"+ numberA + "больше второго значения"+ numberB);
}
else if (numberB>numberA){
    Console.WriteLine("Второе значение"+ numberB + "больше первого значения"+ numberA);
}
