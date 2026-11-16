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



            Console.WriteLine("Qual a Base do retângulo? ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a Altura do retângulo? ");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            double area = baseRetangulo * alturaRetangulo;
            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
