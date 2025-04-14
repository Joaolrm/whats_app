public class Whatsapp
{
    public List<Contatinho> contatos = [];
    public List<Mensagem> mensagens = [];

    public void ListarContatos()
    {
        int i = 1;
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Contato: {i}, Nome: {contato.Nome}, Celular: {contato.Celular}");
            i++;
        }
    }

    public void ListarMensagens()
    {
        foreach (var mensagem in mensagens)
        {
            Console.WriteLine(mensagem.ToString());
        }
    }

    public void NovaMensagem(Mensagem novaMensagem)
    {
        mensagens.Add(novaMensagem);
    }

    public void NovoContato(Contatinho novoContato)
    {
        contatos.Add(novoContato);
    }
}
