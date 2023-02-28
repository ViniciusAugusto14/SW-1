namespace classes;
class Program
{
    static void Main(string[] args)
    {
        classebanco c1 = new classebanco("SP",12387,"Saque",1203981203);
        c1.Deposito(3999);
        Console.WriteLine(c1.TipoTransacao());
    }
}