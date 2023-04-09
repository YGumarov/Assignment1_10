 static int gcd(int a, int b)
{
    if (b == 0)
    {
        return a;
    }
    else
    {
        return gcd(b, a % b);
    }
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine(gcd(a,b));