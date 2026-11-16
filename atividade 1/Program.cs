namespace atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
        }
    }
}
