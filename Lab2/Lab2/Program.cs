//Setul 2, scuzati ca nu i am dat commit in repo la timp

static void P1()
{
    int cnt = 0;
    string input = Console.ReadLine();

    foreach( string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int n = int.Parse(number);
        if(n % 2 == 0)
        {
            cnt++;
        }
    }
    Console.WriteLine(cnt);
}

static void P2()
{
    int neg = 0, z = 0, pos = 0;
    string input = Console.ReadLine();
    foreach (string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int n = int.Parse(number);
        if (n < 0)
        {
            neg++;
        }
        if (n > 0) {
            pos++;
        }
        if( n == 0)
        {
            z++;
        }
    }
    Console.WriteLine($"In secventa sunt: {pos} numere pozitive, {neg} numere negative si {z} zerouri.");
}

static void P3()
{
    Console.WriteLine("Introdu numarul:");
    string input = Console.ReadLine();
    int n = int.Parse(input);
    int sum = 0, prod = 1; 
    for(int i=1; i <= n; i++)
    {
        sum = sum + i;
        prod = prod * i;
    }
    Console.WriteLine($"Suma este {sum}, iar produsul este {prod}.");
}

static void P4()
{
    int poz = -1,pos=0;
    Console.WriteLine("Introdu numarul a:");
    string input = Console.ReadLine();
    int a = int.Parse(input);
    Console.WriteLine("Introdu secventa:");
    input = Console.ReadLine(); 
    foreach(string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        
        int n = int.Parse(number);
        if(n == a)
        {
            poz = pos;
        }
        pos++;
    }
    Console.WriteLine(poz);
}

static void P5()
{
    int poz = 0, cnt = 0;
    string input = Console.ReadLine();
    foreach (string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int n = int.Parse(number);
        if (n == poz)
        {
            cnt++;
        }
        poz++;
    }
    Console.WriteLine(cnt);
}

static void P6()
{
    bool a = true;
    int m=-1;
    string input = Console.ReadLine();
    foreach( string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int n = int.Parse(number);
        if(m > n)
        {
            a = false;
        }
        m = n;
    }
    Console.WriteLine(a);
}

static void P7()
{
    int min=10000, max = -1;
    string input = Console.ReadLine();
    foreach( string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries)){
        int n = int.Parse(number);
        if (min > n)
        {
            min = n;
        }
        if (max < n)
        {
            max = n;
        }
    }
    Console.WriteLine($"Minimul este {min}, iar maximul este {max}.");
}

static void P10()
{
    int lungimeMaxima = 0;
    int lungimeCurenta = 0;
    int? ultimulNumar = null; 
    string input = Console.ReadLine();
    foreach (string fragment in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int numarCurent = int.Parse(fragment);
        if (numarCurent == ultimulNumar)
        {
            lungimeCurenta++;
        }
        else
        {
            lungimeCurenta = 1;
        }
        if (lungimeCurenta > lungimeMaxima)
        {
            lungimeMaxima = lungimeCurenta;
        }
        ultimulNumar = numarCurent;
    }
    Console.WriteLine(lungimeMaxima);
}

static void P11()
{
    int sum = 0;
    string input = Console.ReadLine();
    foreach(string number in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
    {
        int n = int.Parse(number);
        sum = sum + (n - 2*n);
    }
    Console.WriteLine(sum);
}

static void P12()
{
    int m = -1, len = 1, lenMax = 0 ;
    string input = Console.ReadLine();
    foreach(string secquency in input.Split('0', StringSplitOptions.RemoveEmptyEntries))
    {
        foreach (string number in secquency.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            int n = int.Parse(number);
            if (n == m + 1)
            {
                len++;

            }
            if (len > lenMax)
            {
                lenMax = len;
            }
            m = n;
        }
        len = 1;
        m = -1;
    }
    Console.WriteLine(lenMax);
}


