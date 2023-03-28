namespace classes;
public class Transacao
{
    public decimal Quantia { get; }
    public DateTime Data { get; }
    public string Notas { get; }

    public Transacao(decimal quantia, DateTime data, string nota)
    {
        // this é opcional 
        this.Quantia = quantia;
        this.Data = data;
        this.Notas = nota; 
    } 
}
