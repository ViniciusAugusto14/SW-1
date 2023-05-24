namespace EXERCICIO_PRESTAÇÃO;
class Program
{
    static void Main(string[] args)
    {
        Contrato p1 = new Contrato();
        ContratoPessoaFisica p2 = new ContratoPessoaFisica();
        ContratoPessoaJuridica p3 = new ContratoPessoaJuridica();
        
        Console.WriteLine("");
        Console.WriteLine("---Pessoa Fisíca----");
        Console.WriteLine("");
        Console.WriteLine("Qual é o valor do contrato?");
        p2.Valor = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Qual é o prazo do contrato?");
        p2.Prazo = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu nome?");
        p2.Nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é seu email?");
        p2.Email = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu telefone?");
        p2.Telefone = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu CPF?");
        p2.Cpf = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o sua Idade?");
        p2.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("O valor da prestação é "+ p2.CalcularPrestação());
        Console.WriteLine("");
        Console.WriteLine("---Pessoa Juridica----");
        Console.WriteLine("");
        Console.WriteLine("Qual é o valor do contrato?");
        p3.Valor = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Qual é o prazo do contrato?");
        p3.Prazo = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu nome?");
        p3.Nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é seu email?");
        p3.Email = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu telefone?");
        p3.Telefone = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o seu CNPJ?");
        p3.CNPJ = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é a inscrição estadual da empresa? ");
        p3.IE = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Qual é o nome da empresa? ");
        p3.NomeEmpresa = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("O valor da prestação é "+ p3.CalcularPrestação());
        Console.WriteLine("");

        p2.MostrarDados();
        p3.MostrarDados();
    }
}
