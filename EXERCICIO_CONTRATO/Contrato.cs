namespace EXERCICIO_CONTRATO;
class Contrato{
    public string? Nome {get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}

    public virtual void MostrarDados(){
        Console.WriteLine("Nome: "+this.Nome);
        Console.WriteLine("Email: "+this.Email);
        Console.WriteLine("Telefone: "+this.Telefone);

    }
}