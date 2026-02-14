namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> numero = null;
            Nullable<double> numero2 = null;

            int? numero3 = null;
            double? numero4 = null;


            System.Console.WriteLine("Valor do numero: " + numero);
            System.Console.WriteLine("Valor do numero: " + numero2);
            //System.Console.WriteLine("Valor do numero: " + palavra);
            System.Console.WriteLine("Valor do numero: " + numero3);
            System.Console.WriteLine("Valor do numero: " + numero4);
            //System.Console.WriteLine("Valor do numero: " + palavra2);
            Console.ReadKey();


            int? a = null;
            int b = a ?? 0;
            System.Console.WriteLine(b);
            Console.ReadKey();

            int? x = 4;
            int? y = 3;
            int? z = x * y;

            System.Console.WriteLine(z);

            Console.ReadLine();

            int? d = 100;
            if (d.HasValue)
            {
                System.Console.WriteLine($"Valor de d: {d.Value}");
            }
            else
            {
                System.Console.WriteLine("d é nulo");
            }


        }
    }
}