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