namespace EXERCICIO_ANIMAIS;
class Program
{
    static void Main(string[] args)
    {
        Homem n1 = new Homem();
        Cao n2 = new Cao();
        Gato n3 = new Gato();

        Console.WriteLine(n1.Fala());
        Console.WriteLine(n2.Fala());
        Console.WriteLine(n3.Fala());


    }
}
