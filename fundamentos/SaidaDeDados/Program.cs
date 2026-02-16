namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saida de dados: Formatação");
            System.Console.WriteLine();

            int idade = 25;
            string nome = "João";
            // Usando interpolação de string
            System.Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos.");
            // Usando concatenação
            System.Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
            // Usando formatação
            System.Console.WriteLine("Meu nome é {0} e tenho {1} anos.", nome, idade);
            // Usando formatação com alinhamento
            System.Console.WriteLine("Meu nome é {0,-10} e tenho {1,5} anos.", nome, idade);
            // Usando formatação com casas decimais
            double salario = 1234.5678;
            System.Console.WriteLine("Meu salário é {0:C2}.", salario);
            // Usando formatação com porcentagem
            double desconto = 0.15;
            System.Console.WriteLine("O desconto é de {0:P1}.", desconto);

            System.Console.ReadLine();
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.ReadLine();
            //sequencia de escapes

            string local = "C:\\Users\\João\\Documents";
            string frase = "Ele disse: \"Olá, mundo!\"";

            System.Console.WriteLine(local);
            System.Console.WriteLine(frase);

            // Usando verbatim string
            string caminho = @"C:\Users\João\Documents";
            string mensagem = @"Ele disse: ""Olá, mundo!""";
            System.Console.WriteLine(caminho);
            System.Console.WriteLine(mensagem);

            string texto = "Linha 1\nLinha 2\nLinha 3";
            System.Console.WriteLine(texto);
            string bolo = "\nBolo \tde \tchocolate";
            System.Console.WriteLine(bolo);

            System.Console.ReadLine();
            Console.ReadKey();
        }
    }
}