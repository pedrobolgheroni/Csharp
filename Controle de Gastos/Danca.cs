namespace SP3072134ControleDeGastos;

public class Danca : Gastos
{
    private readonly decimal _bonus = 0m;
    public Danca(string nome, decimal bonus = 0) : base(nome)
        => _bonus = bonus;

    public override void Acumular()
    {
        decimal acumulo = ValorAcumulado * 0.02m;
        AdicionarValor(acumulo, DateTime.Now, "Margem de Segurança para Dança");
    }

}