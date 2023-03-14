namespace ExercicioAlunos;
class Alunos
{
    public string nome ="";
    public double nota1, nota2;

    //MEDIA -> retorna um double (por exemplo um numero como 8.3)
     public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }
    //SITUAÇÃO -> retorna um string ("APROVADO" ou "REPROVADO")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }

    //MENSAGEM -> nao retorna nada.só mostrana tela os detalhes (nome,media e a situação)
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome +"esta"+ resultadoSituacao+"co a media: "+mediaCalculada);
    }
   

}