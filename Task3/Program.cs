int ackermanFunction(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if (n == 0){
        return ackermanFunction(m - 1, 1);
    }
    else {
        return ackermanFunction(m - 1, ackermanFunction(m, n - 1));
    }
}

Console.WriteLine(ackermanFunction(2, 3));
Console.WriteLine(ackermanFunction(3, 2));