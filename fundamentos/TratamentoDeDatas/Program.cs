namespace consoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tratamento de datas em C#");

            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Data atual: " + dataAtual);
            //extrair informações
            Console.WriteLine("Ano: " + dataAtual.Year);
            Console.WriteLine("Mes: " + dataAtual.Month);
            Console.WriteLine("Dia: " + dataAtual.Day);
            Console.WriteLine("Hora: " + dataAtual.Hour);
            Console.WriteLine("Minuto: " + dataAtual.Minute);
            Console.WriteLine("Segundo: " + dataAtual.Second);
            Console.WriteLine("Milesegundo: " + dataAtual.Millisecond);

            Console.WriteLine(dataAtual.AddDays(30));
            Console.WriteLine(dataAtual.AddMonths(1));
            Console.WriteLine(dataAtual.AddHours(2));
            Console.WriteLine(dataAtual.AddYears(5));

            //obter o dia da semana e do ano
            System.Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);
            System.Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);

            //Data no formato curto e longo
            System.Console.WriteLine("Data no formato curto: " + dataAtual.ToShortDateString());
            System.Console.WriteLine("Data no formato longo: " + dataAtual.ToLongDateString());
            System.Console.WriteLine("Hora no formato curto: " + dataAtual.ToShortTimeString());
            System.Console.WriteLine("Hora no formato longo: " + dataAtual.ToLongTimeString());

            //Criar data especifica usa formata: aaaa, mm, dd
            DateTime dataEspecifica = new DateTime(2024, 6, 1);
            Console.WriteLine("Data atual: " + dataEspecifica);

            //Criar data especifica usa formata: aaaa, mm, dd e hora
            DateTime data_E_HoraEspecifica = new DateTime(2024, 6, 1, 21, 10, 30);
            Console.WriteLine("Data e hora atual: " + data_E_HoraEspecifica);

            Console.ReadKey();
        }
    }
}