// string Numero = Console.WriteLine("Ingrese n: ");
// int numIngresado = Console.WriteLine();



using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 4;//SOLO INICIACILIZACION NO INFLUYE EN NADA
        int n = 0;
        while(opc != 0)
        {
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. el n-ésimo número de Fibonacci");
            Console.WriteLine("2. Saber si es Fibonacci");
            Console.WriteLine("3. m  números de Fibonacci");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Write("Ingrese n: ");

                    n =  Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"F{n} = " + Fibonacci(n)[n]);
                    break;

                case 2:
                    //El número debe estar dentro del rango del punto 1, ya que,
                    // aleatoriamente, me tocaria hacer una lista infinita de la sucesion
                    Console.Write("Ingrese un número: ");
                    int n1 =  Int32.Parse(Console.ReadLine());
                    Console.WriteLine( Fibonacci(n).Contains(n1) ? $"{n1} es número de Fibonacci" : $"{n1} no es número de fibonacci" );
                    break;
                case 3:
                    Console.Write("Ingrese m: ");
                    int n3 =  Int32.Parse(Console.ReadLine());
                    Console.WriteLine(String.Join(" ",Fibonacci(n3)));
                    break;
            }}
    }

    private static List<int> Fibonacci(int num)
    {
        HashSet<int>  rango = new(Enumerable.Range(1, num)); 
        List<int> sucesion = [0, 1];
        
        foreach(int i in rango) 
        {
        sucesion.Add( sucesion[^1]  + sucesion[^2] );
        }
        return sucesion;
    }
}

