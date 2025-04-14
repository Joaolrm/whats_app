public class MsgFoto : Mensagem
{
    public MsgFoto(Contatinho destinatario, string conteudo)
        : base(destinatario, conteudo) { }

    private int Tamanho { get; set; }
}
