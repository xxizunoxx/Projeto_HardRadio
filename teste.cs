public static class Saudacao
{
    public static void PerguntarNome()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine()!;
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

public static class DicionarioNotasAlunos
{
    public static Dictionary<string, List<int>> notasAlunos = new Dictionary<string, List<int>>();

    public static void AdicionarNota(string nomeAluno, int nota)
    {
        if (!notasAlunos.ContainsKey(nomeAluno))
        {
            notasAlunos[nomeAluno] = new List<int>();
        }
        notasAlunos[nomeAluno].Add(nota);
    }

    public static void ExibirNotas()
    {
        foreach (var aluno in notasAlunos)
        {
            string nome = aluno.Key;
            List<int> notas = aluno.Value;
            double media = notas.Count > 0 ? notas.Average() : 0;

            Console.WriteLine($"Aluno: {nome}, Notas: {string.Join(", ", notas)}, Média: {media:F1}");
        }
    }
}

public static class EstoqueLoja
{
    public static Dictionary<string, int> estoque = new Dictionary<string, int>();

    public static void AdicionarProduto(string nomeProduto, int quantidade)
    {
        if (estoque.ContainsKey(nomeProduto))
        {
            estoque[nomeProduto] += quantidade;
        }
        else
        {
            estoque[nomeProduto] = quantidade;
        }
    }

    public static void ExibirEstoque()
    {
        foreach (var produto in estoque)
        {
            Console.WriteLine($"Produto: {produto.Key}, Quantidade em estoque: {produto.Value}");
        }
    }
}

public static class QuizSimples
{
    public static Dictionary<string, string> perguntasRespostas = new Dictionary<string, string>
    {
        {"Qual é a capital da França?", "Paris"},
        {"Qual é o maior planeta do sistema solar?", "Júpiter"},
        {"Quem escreveu 'Dom Quixote'?", "Miguel de Cervantes"}
    };

    public static void IniciarQuiz()
    {
        int pontuacao = 0;

        foreach (var pergunta in perguntasRespostas)
        {
            Console.WriteLine(pergunta.Key);
            string respostaUsuario = Console.ReadLine()!;

            if (respostaUsuario.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Resposta correta!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine($"Resposta incorreta! A resposta correta é: {pergunta.Value}");
            }
        }

        Console.WriteLine($"Quiz finalizado! Sua pontuação: {pontuacao}/{perguntasRespostas.Count}");
    }
}

public static class SistemaLogin
{
    public static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        {"usuario1", "senha123"},
        {"usuario2", "senha456"},
        {"usuario3", "senha789"}
    };

    public static void RealizarLogin()
    {
        Console.WriteLine("Digite o nome de usuário:");
        string nomeUsuario = Console.ReadLine()!;

        Console.WriteLine("Digite a senha:");
        string senha = Console.ReadLine()!;

        if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
        {
            Console.WriteLine("Login bem-sucedido!");
        }
        else
        {
            Console.WriteLine("Nome de usuário ou senha incorretos.");
        }
    }
}

public static class MediaVendasCarros
{
    public static Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    public static void CalcularMediaVendas(string nomeCarro)
    {
        if (vendasCarros.ContainsKey(nomeCarro))
        {
            List<int> vendas = vendasCarros[nomeCarro];
            double media = vendas.Average();
            Console.WriteLine($"A média de vendas do {nomeCarro} é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Carro não encontrado na lista.");
        }
    }
}

public static class IdadeUser
{
    public static void CalcularIdade()
    {
        Console.WriteLine("Digite seu ano de nascimento:");
        int anoNascimento = int.Parse(Console.ReadLine()!);
        int anoAtual = DateTime.Now.Year;
        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Sua idade é: {idade}.");
    }
}

public static class DoacoesRecebidas
{
    static double doacao; 
    static bool tipoDoacao;
    static string tipoDeConta = "";

    public static void LerDados()
    {
        Console.WriteLine("Digite o valor da doação:");
        doacao = double.Parse(Console.ReadLine()!);

        Console.WriteLine("A doação é anônima? (T/F):");
        //tipoDoacao = bool.Parse(Console.ReadLine()!);
        if (Console.ReadLine()!.ToLower() == "t")
        {
            tipoDoacao = true;
            Console.WriteLine("Anônima");
        }
        else
        {
            tipoDoacao = false;
            Console.WriteLine("Não anônima");
        }
        Console.WriteLine("Digite o tipo de conta (C/P):");
        if (Console.ReadLine()!.ToLower() == "c")
        {
            tipoDeConta = "Corrente";
        }
        else
        {
            tipoDeConta = "Poupança";
        }
    }
    public static void ExibirDoacao()
    {
        Console.WriteLine($"Valor recebido: R$ {doacao:F2}");
        if (tipoDoacao == true)
        {
            Console.WriteLine($"Doação anônima: {tipoDoacao}");
        }
        else
        {
            Console.WriteLine($"Doação anônima: {tipoDoacao}");
        }
        if (tipoDeConta == "Corrente")
        {
            Console.WriteLine($"Tipo de conta: {tipoDeConta}");
        }
        else
        {
            Console.WriteLine($"Tipo de conta: {tipoDeConta}");
        }
    }
}

public static class MilhasEmKm
{
    public static void ConverterMilhasParaKm()
    {
        Console.WriteLine("Digite a distância em milhas:");
        double milhas = double.Parse(Console.ReadLine()!);
        double km = milhas * 1.60934;
        Console.WriteLine($"{milhas} milhas equivalem a {km:F4} quilômetros.");
    }
}

public static class MinutosEmHoras
{
    public static void ConverterMinutosParaHoras()
    {
        Console.WriteLine("Digite a quantidade de minutos:");
        int minutos = int.Parse(Console.ReadLine()!);
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;
        Console.WriteLine($"{minutos} minutos equivalem a {horas} horas e {minutosRestantes} minutos.");
    }
}

public static class CalculandoRetangulo
{
    public static void CalcularArea()
    {
        Console.WriteLine("Digite a largura do retângulo:");
        double largura = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a altura do retângulo:");
        double altura = double.Parse(Console.ReadLine()!);
        double area = largura * altura;
        Console.WriteLine($"A área do terreno é: {area:F2} metros quadrados.");
    }
}

public static class CalculandoMedia
{
    public static void CalcularMedia()
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a terceira nota:");
        double nota3 = double.Parse(Console.ReadLine()!);
        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A média das notas é: {media:F1}");
    }
}

public static class ConverterDecimalParaInteiro
{
    public static void Converter()
    {
        Console.WriteLine("Digite o pesso total da carga:");
        decimal pesoDecimal = decimal.Parse(Console.ReadLine()!);
        int pesoInteiro = (int)pesoDecimal;
        Console.WriteLine($"Quantidade de Caminhões necessários: {pesoInteiro}");
    }
}

public static class IncrementoEDecremento
{
    public static void MostrarOperacoes()
    {
        int valor = 5;
        Console.WriteLine("Valor inicial: " + valor);

        valor--;
        Console.WriteLine("Após decremento: " + valor);

        valor++;
        Console.WriteLine("Após incremento: " + valor);

        valor++;
        Console.WriteLine("Após incremento: " + valor);


    }
}

public static class AumentoSalario
{
    public static void CalcularAumento()
    {
        Console.WriteLine("Digite o salário atual:");
        decimal salarioAtual = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a porcentagem de aumento:");
        decimal percentualAumento = decimal.Parse(Console.ReadLine()!);
        decimal aumento = salarioAtual + (salarioAtual * percentualAumento / 100);
        Console.WriteLine($"O novo salário com aumento de {percentualAumento}% é: R$ {aumento:F2}");
    }
}

public static class CalculoRaioCirculo
{
    public static void CalcularAreaECircunferencia()
    {
        Console.WriteLine("Digite o raio do círculo:");
        double raio = double.Parse(Console.ReadLine()!);
        double pi = 3.14159;
        double area = pi * raio * raio;
        double circunferencia = 2 * pi * raio;
        Console.WriteLine($"Área do círculo: {area:F2}");
        Console.WriteLine($"Circunferência do círculo: {circunferencia:F2}");
    }
}
















