public abstract class Mensagem
{
    public Contatinho Destinatario { get; set; }
    public string HoraEnvio { get; set; }
    public string Conteudo { get; set; }

    public override string ToString()
    {
        return $"Enviado as: {HoraEnvio}, Para: {Destinatario.Celular}, Conteudo: {Conteudo}";
    }

    public Mensagem(Contatinho destinatario, string conteudo)
    {
        Destinatario = destinatario;
        HoraEnvio = new DateTime().ToString("HH:mm:ss");
        Conteudo = conteudo;
    }
}
