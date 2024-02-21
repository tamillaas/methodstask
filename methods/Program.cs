
#region task1
int numbers(int a = 16, int b = 8)
{
    return (a / b);
}
console.writeline(numbers());
#endregion
#region task2
int sumarr(params int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
console.writeline(sumarr(2, 3, 4));
#endregion
#region task3
int numbers(int n, int m)
{
    int count = 0;
    for (int i = n; i <= m; i++)
    {
        if (i % 2 != 0)
            count++;

    }
    return count;
}
console.writeline(numbers(5, 10));
#endregion
#region task5
string power(int n)
{
    while (n > 1 && n%2==0)
    {
            n /= 2;
    }      
    if (n == 1)
    {
        return "quvvetidir";
    }
    else
    {
        return "quvveti deyil";
    }
}
Console.WriteLine(power(19));
#endregion



