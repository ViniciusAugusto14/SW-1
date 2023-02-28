namespace classes;

class classebanco{

    public string agencia ;
    public string tipo ;
    public decimal valor;
    public int conta;
    public classebanco(string a,decimal v,string tp,int c){
        this.agencia = a ;
        this.tipo = tp;
        this.valor = v;
        this.conta = c;
    }
    public void Deposito(decimal v){
        Console.WriteLine("Deposito de {0} realizado",v);
    }
    public string InformarAgencia(){
        return this.agencia;
    }
    public int InformarConta(){
        return this.conta;
    }
    public string TipoTransacao(){
        return this.tipo;
    }
   
}