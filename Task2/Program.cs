//Наришите программу, которая найдет сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int FindSumOfEvenNumbers(int m, int n){
    if (m > n) {
        return 0;
    }
    return m + FindSumOfEvenNumbers(m + 1, n);
}

Console.WriteLine(FindSumOfEvenNumbers(1, 15));
