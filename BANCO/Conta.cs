namespace banco;
class Conta 
{
    public int Numero {get;set;}
    public double Saldo { get; set;}
    public double Limite {get;set;}

    public void Depositar(double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if(valor > this.Saldo+this.Limite){
            Console.WriteLine("Você não pode realizar este saque!! Saldo Insuficiente!");
        }else{
            this.Saldo -= valor;
        }
        this.Saldo -= valor;
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }
    public void AjustaLimite(double valor){
        this.Limite = valor; 
    }
    public void CalcularJuros(double Emprestimo, int Prazo, double Taxa ){
         double Prestaçao = Emprestimo/Prazo;
         double Juros = (Taxa/100)*Emprestimo;
         double CalcularJurosePrestaçao = (Prestaçao + Juros);
         double ValorTotal = CalcularJurosePrestaçao*Prazo;
         Console.WriteLine("o valor do emprestimo: "+ Emprestimo + " reais");
         Console.WriteLine("o Prazo será de: " + Prazo + " meses");
         Console.WriteLine("A Taxa será de: "+ Taxa + "%");
         Console.WriteLine("O valor da prestaçao será:"+ Prestaçao);
         Console.WriteLine("O valor do juros será:"+ Juros);
         Console.WriteLine("O valor do juros mais a prestaçao será:"+ CalcularJurosePrestaçao);
         Console.WriteLine("O valor total a pagar será:"+ ValorTotal);
        
    }
}