public class MsgTexto : Mensagem
{
    public MsgTexto(Contatinho destinatario, string conteudo)
        : base(destinatario, conteudo) { }

    private int NumChar { get; set; }
}
