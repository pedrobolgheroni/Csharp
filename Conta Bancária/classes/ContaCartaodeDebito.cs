namespace classes;
public class ContaCartaodeDebito : ContaBancaria
{
    private readonly decimal _depositosMensais = 0m; // só posso utiilizá-lo nessa classe derivada pois é private, e só pode ter leitura (readonly)
    public ContaCartaodeDebito(string nome, decimal saldoInicial, decimal depositosMensais = 0) : base(nome, saldoInicial)
    => _depositosMensais = depositosMensais; // => pois o construtor tem uma informação a mais que o base

    public override void ExecutarTransacoesdeFimdeMes()
    {   
        if (_depositosMensais != 0)
        {
            EfetuarDeposito(_depositosMensais, DateTime.Now, "Adicionar depositos mensais");
        }
    }
}