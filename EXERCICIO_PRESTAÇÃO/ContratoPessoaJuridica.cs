namespace EXERCICIO_PRESTAÇÃO;
class ContratoPessoaJuridica:Contrato{
    public string? CNPJ {get;set;}
    public string? IE{get;set;}
    public string? NomeEmpresa{get;set;}

    public override void MostrarDados()
    {
        Console.WriteLine("----Pessoa Juridica----");
        base.MostrarDados();
        Console.WriteLine("CNPJ: "+this.CNPJ);
        Console.WriteLine("Inscrição Estadual de Empresa: "+this.IE);
        Console.WriteLine("Nome da Empresa: "+ this.NomeEmpresa);
        Console.WriteLine("O valor da prestação: " + CalcularPrestação());
        Console.WriteLine("");
    }
    public override double CalcularPrestação()
    {
        return base.CalcularPrestação() + 3;
    }
}