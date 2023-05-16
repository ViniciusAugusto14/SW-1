namespace EXERCICIO_CONTRATO;
class ContratoPessoaFisica:Contrato{
    public string? Cpf {get;set;}
    public int Idade{get;set;}

    public override void MostrarDados()
    {
        base.MostrarDados();
        Console.WriteLine("Cpf: "+this.Cpf);
        Console.WriteLine("idade: "+this.Idade);
    }
}