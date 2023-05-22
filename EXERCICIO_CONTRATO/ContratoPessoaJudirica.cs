namespace EXERCICIO_CONTRATO;
class ContratoPessoaJuridica:Contrato{
    public string? CNPJ {get;set;}
    public string? IE{get;set;}
    public string? NomeEmpresa{get;set;}

    public override void MostrarDados()
    {
        base.MostrarDados();
        Console.WriteLine("CNPJ: "+this.CNPJ);
        Console.WriteLine("Inscrição Estadual de Empresa: "+this.IE);
        Console.WriteLine("Nome da Empresa: "+ this.NomeEmpresa);
    }
}