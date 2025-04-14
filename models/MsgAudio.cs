public class MsgAudio : Mensagem
{
    public MsgAudio(Contatinho destinatario, string conteudo)
        : base(destinatario, conteudo) { }

    private int Duracao { get; set; }
}
