Console.WriteLine("Atribuindo valores para string , object e dynamic");
Console.WriteLine();
//declarando variaveis
string nome = "Everton";
String titulo = "Engenheiro de software";

Console.WriteLine("Valor string: " + nome);
Console.WriteLine("Valor string: " + titulo);

string valor = "Isto é uma string";

Console.WriteLine("Valor string: " + valor);

valor = "Agora é outra string";

Console.WriteLine("Valor string: " + valor);

//StringBuilder

Console.WriteLine();
Console.ReadLine();

//Object é a classe base de todas as classes em C#. Ela pode armazenar qualquer tipo de dado, seja ele um tipo de valor ou um tipo de referência. No entanto, quando você atribui um valor a uma variável do tipo object, o valor é convertido para o tipo object, o que pode resultar em perda de desempenho devido à necessidade de conversão.

object nota = 10;
object nome2 = "Everton";
object ativo = true;
object letra = 'A';

Console.WriteLine("Valor object: " + nota);
Console.WriteLine("Valor object: " + nome2);
Console.WriteLine("Valor object: " + ativo);
Console.WriteLine("Valor object: " + letra);

Console.WriteLine();
Console.ReadLine();

// dynamic é um tipo de dado que permite que você armazene qualquer tipo de valor, mas sem a necessidade de conversão. Ele é útil quando você não sabe o tipo de dado que será armazenado em tempo de compilação, mas pode resultar em erros em tempo de execução se você tentar acessar membros que não existem no tipo armazenado.

dynamic nota2 = 10;
dynamic nome3 = "Everton";
dynamic ativo2 = true;
dynamic letra2 = 'A';

Console.WriteLine("Valor dynamic: " + nota2);
Console.WriteLine("Valor dynamic: " + nome3);
Console.WriteLine("Valor dynamic: " + ativo2);
Console.WriteLine("Valor dynamic: " + letra2);

Console.WriteLine();
Console.ReadLine();