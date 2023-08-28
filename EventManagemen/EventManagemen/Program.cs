using EventManagemen;



public class Program
{
    private static void Main(string[] args)
    {
        double valorIngresso = 0;
        Console.WriteLine("\n");
        Console.WriteLine("Digite o nome do evento: ");
        var nomeEvento = Console.ReadLine();

        Console.WriteLine("Agora informe o local do evento: ");
        var localEvento = Console.ReadLine();

        Console.WriteLine("O evento será pago? s/n ");
        var pagamento = Console.ReadLine();

        if (pagamento.Equals("s", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Informe o valor do ingresso do evento: ");
            valorIngresso = double.Parse(Console.ReadLine());
        }


        var evento = new Evento(nomeEvento, localEvento, valorIngresso);
        Console.WriteLine("\n");
        Console.WriteLine("Evento criado!!!");
        Console.WriteLine("Informaçoes do evento: ");

        Console.WriteLine("Nome: " + evento.Nome + "\nLocal: " + evento.Local + "\nValor do evento: " + evento.Valor);

        Console.WriteLine("\n");
        Console.WriteLine("O seu evento ainda pode receber 20 pessoas!");
        Console.WriteLine("Deseja adicionar pessoas ao seu evento? s/n");
        string resposta = Console.ReadLine();

        if (resposta.Equals("s", StringComparison.InvariantCultureIgnoreCase))
        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Digite o nome da pessoa: ");
                var nomePessoa = Console.ReadLine();

                Console.WriteLine($"Agora informe o endereço do(a) {nomePessoa}");
                var enderecoPessoa = Console.ReadLine();

                Console.WriteLine($"Agora digite a idade do(a) {nomePessoa}: ");
                var idadePessoa = int.Parse(Console.ReadLine());

                var pessoa1 = new Pessoa(nomePessoa, enderecoPessoa, idadePessoa);

                evento.AddPessoa(pessoa1);

                Console.WriteLine("\n");
                Console.WriteLine("Deseja adicionar mais pessoas ao evento? s/n");
                resposta = Console.ReadLine();

            } while (resposta.Equals("s", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}