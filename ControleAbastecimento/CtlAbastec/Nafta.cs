namespace CtlAbastec;
public class Nafta : Abastecimentos
{
    public Nafta(string nome, decimal valorAtual) : base(nome, valorAtual)
    {}
    
    public override void ExecutarAjustes()
    {
        decimal acrescimo = ValorAcumulado * 0.02m;
        AtualizarValor(acrescimo, DateTime.Now, "Ajustes para Nafta");
    } 
    
}
