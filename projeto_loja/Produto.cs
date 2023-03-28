namespace projeto_loja;
class Produto
{
    public Produto(){
        this.Nome = "TICTOC";
        this.Preço = 15;
    }
    public Produto(string nome){
        this.Nome = nome;
        this.Preço = 10;
    }
    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preço = 10 - (10*desconto/100);
    }
    private string? Nome{get;set;}
    private double Preço {get;set;}

    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraNome(double preço){
        this.Preço = preço;
    }
    public void MostraDados(){
        Console.WriteLine("Nome: "+ this.Nome);
        Console.WriteLine("Preço: "+ this.Preço);
    }
}
