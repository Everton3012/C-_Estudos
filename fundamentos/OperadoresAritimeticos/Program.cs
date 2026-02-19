namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Aritiméticos\n");
            Console.WriteLine("Digite um número: ");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");

            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma de {x} + {y} é: {x + y}");
            Console.WriteLine($"A subtração de {x} - {y} é: {x - y}");
            Console.WriteLine($"A multiplicação de {x} * {y} é: {x * y}");
            double divisao = (double)x / y;
            Console.WriteLine($"A divisão de {x} / {y} é: {divisao}");
            Console.WriteLine($"O módulo de {x}%{y} é: {x % y}");
            Console.ReadKey();

            Console.WriteLine($"Raiz quadrada de {x} é: {Math.Sqrt(x)}");
            Console.WriteLine($"Raiz quadrada de {y} é: {Math.Sqrt(y)}");
            Console.WriteLine($"Potencia de {x} elevado a {y} é: {Math.Pow(x, y)}");
            Console.WriteLine($"Potencia de {y} elevado a {x} é: {Math.Pow(y, x)}");
            Console.ReadKey();
            Console.WriteLine($"o Valor minimo entre {x} e {y} é: {Math.Min(x, y)}");
            Console.WriteLine($"o Valor maximo entre {x} e {y} é: {Math.Max(x, y)}");
            Console.WriteLine($"o Coseno de {x} é: {Math.Cos(x)}");
            Console.WriteLine($"o Coseno de {y} é: {Math.Cos(y)}");
            Console.WriteLine($"o Seno de {x} é: {Math.Sin(x)}");
            Console.WriteLine($"o Seno de {y} é: {Math.Sin(y)}");
            Console.WriteLine($"o Tangente de {x} é: {Math.Tan(x)}");
            Console.WriteLine($"o Tangente de {y} é: {Math.Tan(y)}");
            Console.WriteLine($"o Exponencial de {x} é: {Math.Exp(x)}");
            Console.WriteLine($"o Exponencial de {y} é: {Math.Exp(y)}");
            Console.ReadKey();
        }
    }
}