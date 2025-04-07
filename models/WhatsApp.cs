public class Whatsapp
{
    public List<Contatinho> contatos = [];
    public List<Mensagem> mensagens = [];

    public void ListarContatos()
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine(contato.Nome);
        }
    }

    public void ListarMensagens()
    {
        foreach (var mensagem in mensagens)
        {
            Console.WriteLine(mensagem.ToString());
        }
    }
}
