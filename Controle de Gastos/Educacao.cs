namespace SP3072134ControleDeGastos;

public class Educacao : Gastos
{
    public Educacao(string nome) : base(nome)
    {
    }

    public override void Acumular()
    {
        decimal acumulo = ValorAcumulado * 0.04m;
        AdicionarValor(acumulo, DateTime.Now, "Margem de Segurança para Educação");
    }
}