public abstract class Mensagem
{
    public required Contatinho Destinatario { get; set; }
    public required string HoraEnvio { get; set; }
    public required string Conteudo { get; set; }

    public override string ToString()
    {
        return $"{HoraEnvio} - {Destinatario.Nome}: {Conteudo}";
    }
}
