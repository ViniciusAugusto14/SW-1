namespace projeto_aereoporto;
class Aeroporto
{
    
    public  Aeroporto(){
        this.CodigoAviao = 5789;
        this.EmpresaAviao = "Airlines";
    }

    private int CodigoAviao {get;set;}
    private string? EmpresaAviao {get;set;}


    public void MudarCodigoAviao(int codigoaviao){
        this.CodigoAviao = codigoaviao ;
    }
    public void MudarEmpresaAviao(string empresaaviao){
        this.EmpresaAviao = empresaaviao;
    }
    public void MostraDados(){
        Console.WriteLine("Codigo do Avião: "+ this.CodigoAviao);
        Console.WriteLine("Empresa do Aviao: "+ this.EmpresaAviao);
    }
}
