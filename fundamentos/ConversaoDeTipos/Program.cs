namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Tipos");

            int varInt = 100;
            double varDouble = varInt; // Conversão implícita de int para double
            long numeroLong = (long) varDouble;// Conversão explícita de double para long
            Console.WriteLine($"Valor do double: {numeroLong}");

            int varInt2 = 200;
            double varDouble2 = 100.500;

            float resultado = (float) (varInt2 / varDouble2); // Conversão explícita de double para float

            bool valorBool = true;
           

            System.Console.WriteLine($"Resultado da divisão: { resultado.ToString()}");

            System.Console.WriteLine(Convert.ToString(valorBool));
            System.Console.WriteLine(valorBool);
            System.Console.WriteLine(valorBool.ToString());

            Console.ReadKey();
        }
    }
}