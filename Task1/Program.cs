//Напишите программу, которая выведет все четные натуральные числа в промежутке от M до N с помощью рекурсии.

void PrintEvenNumbers(int m, int n) 
{
    if (m > n) {
        return;
    }
    if (m % 2 == 0) {
        Console.WriteLine(m);
    }
    PrintEvenNumbers(m + 1, n);
}

PrintEvenNumbers(4, 8);
