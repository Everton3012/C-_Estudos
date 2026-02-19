namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada de Dados");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Olá, {nome}!");
            Console.WriteLine($"sua idade é de {idade} anos!");
                Console.WriteLine($"sua altura é de {altura} metros!");
            Console.ReadKey();
        }
    }
}