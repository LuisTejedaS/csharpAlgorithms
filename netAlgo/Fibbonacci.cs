namespace HelloWorld;

class Fibbonacci
{

    static int Calculate(int kth)
    {
        if (kth == 1)
        {
            return 0;
        }
        if (kth == 2)
        {
            return 1;
        }

        int k2 = 0;
        int k1 = 1;


        int iteration = 3;
        int currentFibbo = 0;
        while (iteration <= kth)
        {
            currentFibbo = k2 + k1;
            k2 = k1;
            k1 = currentFibbo;
            iteration++;
        }
        return currentFibbo;

    }
    public static void Test()
    {
        Console.WriteLine(Calculate(1));
        Console.WriteLine(Calculate(2));
        Console.WriteLine(Calculate(3));
        Console.WriteLine(Calculate(4));
        Console.WriteLine(Calculate(5));
    }
}