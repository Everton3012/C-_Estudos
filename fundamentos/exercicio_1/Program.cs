namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 35;
            string nome = "Maria";
            float altura = 3.45f;
            DateTime data = new DateTime(1999, 09, 04);
            const int ANO = 12;
            float? nota = 7.80f;

            System.Console.WriteLine("Idade: " + idade);
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Altura: " + altura);
            System.Console.WriteLine("Data de nascimento: " + data.ToShortDateString());
            System.Console.WriteLine("Constante ANO: " + ANO);
            System.Console.WriteLine("Nota: " + nota);

            int x = 77;
            System.Console.WriteLine("Valor de x: " + x);
            int y = 66;
            System.Console.WriteLine("Valor de y: " + y);
            int z = x + y;
            System.Console.WriteLine("Soma de x e y: " + z);

            float a = 5.5f;
            System.Console.WriteLine("Valor de a: " + a);
            float b = 2.3f;
            System.Console.WriteLine("Valor de b: " + b);
            float c = a * b;
            System.Console.WriteLine("Multiplicação de a e b: " + c);

            decimal d = 100.50m;
            System.Console.WriteLine("Valor de d: " + d);
            decimal e = 50.25m;
            System.Console.WriteLine("Valor de e: " + e);
            decimal f = d - e;
            System.Console.WriteLine("Subtração de d e e: " + f);
            short g = 10;
            System.Console.WriteLine("Valor de g: " + g);
            short h = 5;
            System.Console.WriteLine("Valor de h: " + h);
            short i = (short)(g / h);
            System.Console.WriteLine("Divisão de g e h: " + i);
            byte j = 255;
            System.Console.WriteLine("Valor de j: " + j);
            byte k = 10;
            System.Console.WriteLine("Valor de k: " + k);
            byte l = (byte)(j + k);
            System.Console.WriteLine("Soma de j e k: " + l);
            bool m = true;
            System.Console.WriteLine("Valor de m: " + m);
            bool n = false;
            System.Console.WriteLine("Valor de n: " + n);
            bool o = m && n;
            System.Console.WriteLine("Resultado de m AND n: " + o);
            bool? p = null;
            if (p.HasValue)
            {
                System.Console.WriteLine("Valor de p: " + p.Value);
            }
            else
            {
                System.Console.WriteLine("p é nulo");
            }


        }
    }
}