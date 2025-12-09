using System.Runtime.CompilerServices;

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

// Exercício: Ordenar Números 1042 beecrowd
public static class OrdenarNumeros
{
    public static void Ordenar()
    {   
        List<int> numeros = new List<int> ();
        foreach (var valoresStr in Console.ReadLine()!.Split(' '))
        {
            int valor = int.Parse(valoresStr);
            numeros.Add(valor);
        }

        List<int> ordenados = new List<int> (numeros);
        ordenados.Sort();
        foreach (var num in ordenados)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine();

        foreach (var num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}

public static class AreaTriangulo
{
    public static void CalcularArea()
    {
        List<float> numeros = new List<float> ();
        foreach (var valoresStr in Console.ReadLine()!.Split(' '))
        {
            float valor = float.Parse(valoresStr);
            numeros.Add(valor);
        }
        numeros.Sort();
        numeros.Reverse();

        float A = numeros[0];
        float B = numeros[1];
        float C = numeros[2];
        Console.WriteLine($"{A} {B} {C}");
        if (A < B + C)
        {
            float perimetro = A + B + C;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            float area = ((A + B) * C) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }
}

public static class Multiplos
{
    public static void VerificarMultiplos()
    {
        List<string> numeros = new List<string> ();
        foreach (var valoresStr in Console.ReadLine()!.Split(' '))
        {
            string valor = valoresStr;
            numeros.Add(valor);
        }

        int A = int.Parse(numeros[0]);
        int B = int.Parse(numeros[1]);

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}

public static class TiposDeTriangulo
{
    public static void VerificarTipoTriangulo()
    {
        List<float> numeros = new List<float> ();
        foreach (var valoresStr in Console.ReadLine()!.Split(' '))
        {
            float valor = float.Parse(valoresStr);
            numeros.Add(valor);
        }

        numeros.Sort();
        numeros.Reverse();
        float A = numeros[0];
        float B = numeros[1];
        float C = numeros[2];

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (A * A == B * B + C * C)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (A * A > B * B + C * C)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (A * A < B * B + C * C)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (A == B && B == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || A == C || B == C)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}

public static class TempoDeJogo
{
    public static void CalcularTempo()
    {
        string[] valoresStr = Console.ReadLine()!.Split(' ');

        int horaInicio = int.Parse(valoresStr[0]);
        int horaFim = int.Parse(valoresStr[1]);
        int duracao;

        if (horaInicio < horaFim)
        {
            duracao = horaFim - horaInicio;
        }
        else
        {
            duracao = (24 - horaInicio) + horaFim;
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }
}

public static class TempoDeJogoHorasMinutos
{
    public static void CalcularTempo()
    {
        string[] valoresStr = Console.ReadLine()!.Split(' ');

        int horaInicio = int.Parse(valoresStr[0]);
        int minutoIncio = int.Parse(valoresStr[1]);
        int horaFim = int.Parse(valoresStr[2]);
        int minutoFim = int.Parse(valoresStr[3]);
        int duracao;

        int totalInicio = horaInicio * 60 + minutoIncio;
        int totalFim = horaFim * 60 + minutoFim;

        if (totalFim <= totalInicio)
        {
            totalFim += 24 * 60;
        }

        duracao = totalFim - totalInicio;
        int horas = duracao / 60;
        int minutos = duracao % 60;
        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }
}

public static class AumentoDeSalario
{
    public static void CalcularAumento()
    {
        double salario = double.Parse(Console.ReadLine()!);
        double percentualAumento;

        if (salario <= 400.00)
        {
            percentualAumento = 0.15;
        }
        else if (salario <= 800.00)
        {
            percentualAumento = 0.12;
        }
        else if (salario <= 1200.00)
        {
            percentualAumento = 0.10;
        }
        else if (salario <= 2000.00)
        {
            percentualAumento = 0.07;
        }
        else
        {
            percentualAumento = 0.04;
        }

        double aumento = salario * percentualAumento;
        double novoSalario = salario + aumento;

        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {aumento:F2}");
        Console.WriteLine($"Em percentual: {percentualAumento * 100} %");
    }
}

public static class Animal
{
    public static void DefinaOAnimal()
    {
        string nivel1 = Console.ReadLine()!;
        string nivel2 = Console.ReadLine()!;
        string nivel3 = Console.ReadLine()!;

        if (nivel1 == "vertebrado")
        {
            if (nivel2 == "ave")
            {
                if (nivel3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else if (nivel3 == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
            else if (nivel2 == "mamifero")
            {
                if (nivel3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else if (nivel3 == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else if (nivel1 == "invertebrado")
        {
            if (nivel2 == "inseto")
            {
                if (nivel3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (nivel3 == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
            else if (nivel2 == "anelideo")
            {
                if (nivel3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (nivel3 == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}

public static class DDD
{
    public static void IdentificarCidade()
    {
        int ddd = int.Parse(Console.ReadLine()!);

        switch (ddd)
        {
            case 61:
                Console.WriteLine("Brasilia");
                break;
            case 71:
                Console.WriteLine("Salvador");
                break;
            case 11:
                Console.WriteLine("Sao Paulo");
                break;
            case 21:
                Console.WriteLine("Rio de Janeiro");
                break;
            case 32:
                Console.WriteLine("Juiz de Fora");
                break;
            case 19:
                Console.WriteLine("Campinas");
                break;
            case 27:
                Console.WriteLine("Vitoria");
                break;
            case 31:
                Console.WriteLine("Belo Horizonte");
                break;
            default:
                Console.WriteLine("DDD nao cadastrado");
                break;
        }
    }
}

public static class ImpostoDeRenda
{
    public static void CalcularImposto()
    {
        double salario = double.Parse(Console.ReadLine()!);
        double imposto;

        if (salario <= 2000.00)
        {
            imposto = 0.0;
        }
        else if (salario <= 3000.00)
        {
            imposto = (salario - 2000.00) * 0.08;
        }
        else if (salario <= 4500.00)
        {
            imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
        }
        else
        {
            imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
        }

        if (imposto == 0.0)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}

public static class NumerosPares
{
    public static void ExibirNumerosPares()
    {
        for (int i = 2; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}

public static class NumerosPositivos
{
    public static void ContarNumerosPositivos()
    {
        int contador = 0;

        for (int i = 0; i < 6; i++)
        {
            double numero = double.Parse(Console.ReadLine()!);
            if (numero > 0)
            {
                contador++;
            }
        }

        Console.WriteLine($"{contador} valores positivos");
    }
}

public static class TempoDeUmEvento
{
    public static void CalcularTempo()
    {
        string[] dtInicial = Console.ReadLine()!.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int diaInicio = int.Parse(dtInicial[1]);

        string[] horaInicial = Console.ReadLine()!.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        int horaInicio = int.Parse(horaInicial[0]);
        int minutoInicio = int.Parse(horaInicial[1]);
        int segundoInicio = int.Parse(horaInicial[2]);

        string[] dtFinal = Console.ReadLine()!.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int diaFim = int.Parse(dtFinal[1]);

        string[] horaFinal = Console.ReadLine()!.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        int horaFim = int.Parse(horaFinal[0]);
        int minutoFim = int.Parse(horaFinal[1]);
        int segundoFim = int.Parse(horaFinal[2]);

        int inicio = diaInicio * 86400 + horaInicio * 3600 + minutoInicio * 60 + segundoInicio;
        int fim = diaFim * 86400 + horaFim * 3600 + minutoFim * 60 + segundoFim;

        int duracao = fim - inicio;

        int dias = duracao / 86400;
        duracao %= 86400;

        int horas = duracao / 3600;
        duracao %= 3600;

        int minutos = duracao / 60;
        int segundos = duracao % 60;

        Console.WriteLine($"{dias} dia(s)");
        Console.WriteLine($"{horas} hora(s)");
        Console.WriteLine($"{minutos} minuto(s)");
        Console.WriteLine($"{segundos} segundo(s)");
    }
}

public static class NumerosPositivosEMedia
{
    public static void ContarNumerosPositivos()
    {
        int contador = 0;
        List<double> soma = new List<double>();
        double media = 0;

        for (int i = 0; i < 6; i++)
        {
            double numero = double.Parse(Console.ReadLine()!);
            if (numero > 0)
                {
                    contador++;
                    soma.Add(numero);
                }
        }
        if (soma.Count > 0)
        {
            media = soma.Average();
        }

        Console.WriteLine($"{contador} valores positivos");
        Console.WriteLine($"{media:F1}");
    }
}




