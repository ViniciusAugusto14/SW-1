namespace projeto_aereoporto;
class Aeroporto
{
    private int CodigoAviao {get;set;}
    private string? EmpresaAviao {get;set;}
     private string? CidadeIda {get;set;}
    private string? CidadeVolta {get;set;}


    public void MudarCodigoAviao(int codigoaviao){
        this.CodigoAviao = codigoaviao ;
    }
    public void MudarEmpresaAviao(string empresaaviao){
        this.EmpresaAviao = empresaaviao;
    }
    public void MudarCidadeIda(string cidadeida){
        this.CidadeIda = cidadeida;
    }
    public void MudarCidadeVolta(string cidadevolta){
        this.CidadeVolta = cidadevolta;
    }
    public void MostraDados(){
        Console.WriteLine("Codigo do Avião: "+ this.CodigoAviao);
        Console.WriteLine("Empresa do Aviao: "+ this.EmpresaAviao);
        Console.WriteLine("Cidade de ida: "+ this.CidadeIda);
        Console.WriteLine("Cidade de Volta: "+ this.CidadeVolta);

    }
}
