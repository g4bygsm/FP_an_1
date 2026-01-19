//SETUL 1 DE PROBLEME
using System.Runtime.Intrinsics.X86;

static void P1()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int x; 

    x = -b / a;
    Console.WriteLine(x);
}


static void P2()
{
    int a, b, c, x, delta;
    Console.WriteLine("Introduceti valoarea lui a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti valoarea lui b: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti valoarea lui c: ");
    c = Convert.ToInt32(Console.ReadLine());
    delta = b * b - 4 * a * c;
    Console.WriteLine(
        "Delta este: " + delta);
    if (delta < 0)
        Console.WriteLine(
            "Ecuatia nu are solutii reale.");
    else if (delta == 0)
    {
        x = -b / (2 * a);
        Console.WriteLine(
            "Ecuatia are o singura solutie reala: x = " + x);
    }
    else
    {
        int x1 = (-b + (int)Math.Sqrt(delta)) / (2 * a);
        int x2 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"Ecuatia are doua solutii reale: x1 = {x1} si x2 = {x2}");
    }
}


static bool P3()
{

    int n, k;
    Console.WriteLine("Introduceti valoarea lui n: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti valoarea lui k: ");
    k = Convert.ToInt32(Console.ReadLine());
    if (n % k == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


static bool P4()
{
    int y;
    Console.WriteLine("Introduceti anul: ");
    y = Convert.ToInt32(Console.ReadLine());
    if (y % 4 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void P5()
{
    int n, k;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti numarul cifrei: ");
    k = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < k; i++)
    {
        n = n / 10;
    }

    int cif = n % 10;
    Console.WriteLine($"Cifra este {cif}");
}

static bool P6()
{
    int a, b, c;
    Console.WriteLine("Introduceti primul numar: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti al doilea numar: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti al treilea numar: ");
    c = Convert.ToInt32(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void P7()
{
    int a, b, c;
    Console.WriteLine("Introduceti valoarea lui a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti valoarea lui b: ");
    b = Convert.ToInt32(Console.ReadLine());

    c = a;
    a = b;
    b = c;


    Console.WriteLine($"a={a} si b={b}");
}

static void P8()
{
    int a, b;
    Console.WriteLine("Introduceti valoarea lui a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti valoarea lui b: ");
    b = Convert.ToInt32(Console.ReadLine());
    a = a + b;
    b = a - b;
    a = a - b;
    Console.WriteLine($"a= {a} si b= {b}");

}

static void P9()
{
    int n;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            Console.Write($"{i} ");
        }
    }
}

static bool P10()
{
    int n;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

static void P11()
{
    int n;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());
    while (n != 0)
    {
        Console.Write($"{n % 10}");
        n /= 10;
    }
}

static void P12()
{
    int n, a, b, cnt = 0;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("In intervalul de la: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" la: ");
    b = Convert.ToInt32(Console.ReadLine());
    for (int i = a; i <= b; i++)
    {
        if (i % n == 0)
        {
            cnt++;
        }
    }
    Console.WriteLine($"Numarul de divizori este {cnt}");
}

static void P13()
{
    int y1, y2, cnt = 0;
    Console.WriteLine("Introduceti primul an: ");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduceti al doilea an: ");
    y2 = Convert.ToInt32(Console.ReadLine());
    for (int i = y1; i <= y2; i++)
    {
        if (i % 4 == 0)
        {
            cnt++;
        }
    }
    Console.WriteLine($"Numarul de ani bisecti este {cnt}");
}

static bool P14()
{
    int n, m = 0;
    Console.WriteLine("Introduceti numarul: ");
    n = Convert.ToInt32(Console.ReadLine());
    int temp = n;
    while (n != 0)
    {
        m = m * 10 + n % 10;
        n /= 10;
    }
    if (temp == m)
    {
        return true;
    }
    return false;

}

static void P15()
{
    int a, b, c;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());

    int[] numere = { a, b, c };
    Array.Sort(numere);

    Console.WriteLine("Numerele in ordine crescatoare sunt:");
    foreach (int n in numere)
    {
        Console.Write(n + " ");
    }
}

static void P16()
{

    int a, b, c, d, e;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    d = Convert.ToInt32(Console.ReadLine());
    e = Convert.ToInt32(Console.ReadLine());
    int aux;

    if (a > b) { aux = a; a = b; b = aux; }
    if (a > c) { aux = a; a = c; c = aux; }
    if (a > d) { aux = a; a = d; d = aux; }
    if (a > e) { aux = a; a = e; e = aux; }

    if (b > c) { aux = b; b = c; c = aux; }
    if (b > d) { aux = b; b = d; d = aux; }
    if (b > e) { aux = b; b = e; e = aux; }

    if (c > d) { aux = c; c = d; d = aux; }
    if (c > e) { aux = c; c = e; e = aux; }

    if (d > e) { aux = d; d = e; e = aux; }

    Console.WriteLine("Numerele in ordine crescatoare sunt:");
    Console.WriteLine($"{a} {b} {c} {d} {e}");
}

static void P17()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int x = a, y = b;
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    int cmmdc = a;
    int cmmmc = (x * y) / cmmdc;
    Console.WriteLine($"Cel mai mare divizor comun (CMMDC) este: {cmmdc}");
    Console.WriteLine($"Cel mai mic multiplu comun (CMMMC) este: {cmmmc}");
}

static void P18()
{
    Console.Write("Introdu numarul n: ");
    int n = int.Parse(Console.ReadLine());
    int x = n;
    Console.Write($"Descompunerea in factori primi a lui {x} este: ");
    bool primulFactor = true;
    for (int d = 2; d * d <= n; d++)
    {
        int p = 0;
        while (n % d == 0)
        {
            p++;
            n /= d;
        }
        if (p > 0)
        {
            if (!primulFactor) Console.Write(" x ");
            Console.Write($"{d}^{p}");
            primulFactor = false;
        }
    }
    if (n > 1)
    {
        if (!primulFactor) Console.Write(" x ");
        Console.Write($"{n}^1");
    }
    Console.WriteLine();
}

static bool P19()
{
    int n = int.Parse(Console.ReadLine());
    int temp = n;
    int x = n % 10;
    int y;
    while (n != 0)
    {
        if (n % 10 != x)
        {
            y = n % 10;
        }
        n /= 10;
    }
    while (temp != 0)
    {
        if (temp % 10 != x && temp % 10 != x)
        {
            return false;
        }
    }
    return true;
}

static void P20()
{
    int m = 13;
    int n = 30;
    double d;

    d = (double)m / n;
    Console.WriteLine(d);

    double fract = d - Math.Truncate(d);

    int maxDecimal = 6;
    while (maxDecimal > 0 && fract != 0)
    {
        // fract = 0.43
        int cifraZecimala;
        cifraZecimala = (int)Math.Truncate(fract * 10);
        Console.WriteLine($"{cifraZecimala} ");


        fract = fract * 10 - Math.Truncate(fract * 10);


        maxDecimal--;
    }
}

static void P21()
{
    int st = 1;
    int dr = 1024;
    string rsp;

    Console.WriteLine("Gandeste-te la un numar intre 1 si 1024!");

    while (st < dr)
    {
        int mij = (st + dr) / 2;
        Console.Write($"Numarul este mai mare sau egal decat {mij}? ");
        rsp = Console.ReadLine();

        if (rsp == "da")
            st = mij;
        else
            dr = mij - 1;
    }

    Console.WriteLine($"Numarul la care te-ai gandit este: {st}");
}


void Palindrom()
{
    string line = Console.ReadLine();
    char[] seps = { ' ', ';'};
    string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
   
    foreach(string token in tokens)
    {
        Console.WriteLine($"{token}, {new string(token.Reverse().ToArray())}");
    }
}

Palindrom();
