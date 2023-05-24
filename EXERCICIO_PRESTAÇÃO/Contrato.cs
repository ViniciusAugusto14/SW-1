namespace EXERCICIO_PRESTAÇÃO;
class Contrato{
    public string? Nome {get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}
    public double Valor {get;set;}
    public int Prazo {get;set;}

    public virtual void MostrarDados(){
        Console.WriteLine("Nome: "+this.Nome);
        Console.WriteLine("Email: "+this.Email);
        Console.WriteLine("Telefone: "+this.Telefone);
    
    }
    public virtual double CalcularPrestação(){
        return Valor/Prazo;
    }
}