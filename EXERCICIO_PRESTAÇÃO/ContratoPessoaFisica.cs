namespace EXERCICIO_PRESTAÇÃO;
class ContratoPessoaFisica:Contrato{
    public string? Cpf {get;set;}
    public int Idade{get;set;}

    public override void MostrarDados()
    {
        Console.WriteLine("----Pessoa Fisica----");
        base.MostrarDados();
        Console.WriteLine("Cpf: "+this.Cpf);
        Console.WriteLine("idade: "+this.Idade);
        Console.WriteLine("O valor da prestação: " + CalcularPrestação());
        Console.WriteLine("");
    }
    public override double CalcularPrestação()
    {
        if(Idade<=30){
            return base.CalcularPrestação() + 1;
        }else if(Idade<=40){
            return base.CalcularPrestação() + 2;
        }else if(Idade<=50){
            return base.CalcularPrestação() + 3;
        }else{
            return base.CalcularPrestação() + 4;
        }
    }
}