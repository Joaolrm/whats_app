class Program
{
    static void Main(string[] args)
    {
        Contatinho contato = new Contatinho("Lucas", "123456789");
        Whatsapp whatsapp = new Whatsapp();
        Mensagem mensagem = new MsgTexto(contato, "Olá, tudo bem?");
        whatsapp.NovaMensagem(mensagem);
        whatsapp.ListarMensagens();
        whatsapp.NovoContato(contato);
        whatsapp.ListarContatos();
    }
}
