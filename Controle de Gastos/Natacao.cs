namespace SP3072134ControleDeGastos;

public class Natacao : Gastos
{
    public Natacao(string nome) : base(nome)
    {
    }

    public override void Acumular()
    {
        decimal acumulo = ValorAcumulado * 0.02m;
        AdicionarValor(acumulo, DateTime.Now, "Margem de Segurança para Natação");
    }
}