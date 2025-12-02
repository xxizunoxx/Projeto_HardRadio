public static class Saudacao
{
    public static void PerguntarNome()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + "!");
    }
}
public static class Atividade

{
    public static List<string> linguagens = new List<string> 
    {
        "C#",
        "Java",
        "JavaScript"
    };
    public static void AtividadeUm()
    {
        string notaMedia = "4";
        int notaConvertida = int.Parse(notaMedia);

        if (notaConvertida >= 5)
        {
            Console.WriteLine("Nota suficiente para aprovação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
    public static void AtividadeDois()
    {
        Console.WriteLine("Linguagem selecionada: " + linguagens[0]);
    }
    public static void AtividadeTres()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine(linguagens[numero]);
    }
}

public static class JogaDoAdivinha
{
    public static void IniciarJogo()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 100);
        int tentativas = 10;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Você tem " + tentativas + " tentativas para adivinhar o número entre 1 e 100.");

        for (int i = 0; i < tentativas; i++)
        {
            Console.WriteLine("Digite seu palpite:");
            int palpite = int.Parse(Console.ReadLine()!);

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você adivinhou o número!");
                return;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor.");
            }
            else
            {
                Console.WriteLine("Número incorreto. Tente novamente.");
            }
        }

        Console.WriteLine("Suas tentativas acabaram. O número secreto era: " + numeroSecreto);
    }
}


/*public static class JogoDoAdivinha
{
    public static void IniciarJogo()
    {
        // Cria o número secreto entre 1 e 100
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); 
        int tentativas = 10;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine($"Você tem {tentativas} tentativas para adivinhar o número entre 1 e 100.");

        for (int i = 0; i < tentativas; i++)
        {
            Console.Write("Digite seu palpite: ");

            // Lê o palpite e valida se é número
            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out int palpite))
            {
                Console.WriteLine("Entrada inválida! Digite apenas números.");
                i--; // Não desconta a tentativa
                continue;
            }

            // Verifica o palpite
            if (palpite == numeroSecreto)
            {
                Console.WriteLine("🎉 Parabéns! Você adivinhou o número!");
                return;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("🔼 O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("🔽 O número secreto é menor.");
            }

            Console.WriteLine($"Tentativas restantes: {tentativas - i - 1}");
        }

        Console.WriteLine($"❌ Suas tentativas acabaram. O número secreto era: {numeroSecreto}");
    }
}
*/

public static class OperacoesMatematicas
{
    public static void RealizarOperacoes()
    {
        float a = 10.5f;
        float b = 5.6f;

        Console.WriteLine("Soma: " + (a + b));
        Console.WriteLine("Subtração: " + (a - b));
        Console.WriteLine("Multiplicação: " + (a * b));
        Console.WriteLine("Divisão: " + (a / b));
    }
}

public static class ListaBandas
{
    public static List<string> bandas = new List<string>();
    
    public static void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu de Bandas:");
            Console.WriteLine("1 - Adicionar Banda");
            Console.WriteLine("2 - Listar Bandas");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Digite o nome da banda: ");
                    AddBandas();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    ListarBandas();
                    Console.ReadKey();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    public static void AddBandas()
    {
        string banda = Console.ReadLine()!;
        bandas.Add(banda);
        Console.WriteLine("Banda adicionada: " + banda);
    }

    public static void ListarBandas()
    {
        Console.WriteLine("Bandas na lista:");
        for (int i = 0; i < bandas.Count; i++)
        {
            Console.WriteLine("- " + bandas[i]);
        }
    }
}

public static class SomarListaInteiros
{
    public static List<string> numeros = new List<string>{"10", "20", "30", "40", "50"};
    public static void SomarLista()
    {
        int soma = 0;
        foreach (var numStr in numeros)
            {
                int num = int.Parse(numStr);
                soma += num;
            }
        Console.WriteLine("A soma dos números na lista é: " + soma);
    }
}

public static class ExibirNumerosPares
{
    public static void MostrarNumerosPares()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Números pares utilizando for:");
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        Console.WriteLine("\nNúmeros pares utilizando foreach:");
        foreach (var numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }
    }
}

public static class ExibirTituloDaOpcao
{
    public static void MostrarTitulo(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras + 4, '*');
    }
}