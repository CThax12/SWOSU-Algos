public class Program {

    public static int FibonacciRecursive(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }

    public static void Fibonacci(int n)
{
    int a = 0;
    int b = 1;
    
    for (int i = 0; i < n; i++)
    {
        int c = a + b;
        Console.Write(a + " ");
        a = b;
        b = c;
    }
}


    public static void Main(String[] args) {

         var watch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 0; i < 20; i++)
    {
           
        Console.Write(FibonacciRecursive(i));
        Console.WriteLine();
         watch.Stop();


    }
            Console.WriteLine("Recursive time: " + watch.Elapsed.TotalMilliseconds);

        Console.WriteLine();

   
    
         var watchtwo = System.Diagnostics.Stopwatch.StartNew();
           
        Fibonacci(20);
         watchtwo.Stop();

         Console.WriteLine("\nIterative time: " + watchtwo.Elapsed.TotalMilliseconds);



    }

    
}