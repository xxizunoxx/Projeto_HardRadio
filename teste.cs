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