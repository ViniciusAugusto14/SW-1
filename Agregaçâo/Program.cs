namespace Agregaçâo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com agregação!");

        //instanciando um objeto de cada classe 
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //adicionando um nome  para um cliente
        cli.Nome ="Vinicius Augusto";

        //adicionando um numero e validade para o cartao de credito
        cdc.Numero = "1234565789";
        cdc.DataValidade = "07/2027";

        //Associando  o clienete com o atributo de agregação em Cartao de credito
        cdc.Cliente = cli;

        //Visualizando Informacoes
        Console.WriteLine("o nome do cliente é " + cli.Nome);
        Console.WriteLine("O numero do Cartao é "+ cdc.Numero);
        Console.WriteLine("A data de Validade do Cartao é "+ cdc.DataValidade);
        Console.WriteLine("o nome do cliente AGREGADO é " + cdc.Cliente.Nome);

    }
}
