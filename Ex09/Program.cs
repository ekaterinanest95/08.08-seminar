/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/



int number = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {number}"); // Интерполяция, в отличии от конкатенации, преобразует к выводу, к которому мы привыкли

int firstDigit = number / 10;
int secondDigit = number %10;

if(firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
