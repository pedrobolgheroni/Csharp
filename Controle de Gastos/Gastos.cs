namespace SP3072134ControleDeGastos;

public class Gastos{
    public string Cliente { get; }
    public decimal ValorAcumulado 
    {
        get 
        {
            decimal valorAcumulado = 0m; 
            foreach (var item in todasTransacoes) 
            {
                valorAcumulado += item.Valor; 
            }
            return valorAcumulado;
        }
    }
     private List<Transacao> todasTransacoes = new List<Transacao>();

    public Gastos(string nome)
    {
       this.Cliente = nome;

    }

     public void AdicionarValor(decimal valor, DateTime data, string descricao)
    {  
        var adicionar = new Transacao(valor, data, descricao);
        todasTransacoes.Add(adicionar);
    }


    public string ObterHistoricodeConta()
    {

        var relatorio = new System.Text.StringBuilder(); //StringBuilder emite as informações com a condição de tabulação

        decimal valorAcumulado = 0m;
        relatorio.AppendLine("Data           Valor  Valor Acumulado   Descrição"); // AppendLine() - Adiciona ao final da linha \t - tabulação

        foreach (var item in todasTransacoes)
        {   
            valorAcumulado += item.Valor;
            relatorio.AppendLine($"{item.Data.ToShortDateString(), -10}{item.Valor, 10}{valorAcumulado, 17}{"   "}{item.Descricao}");
        }   

        return relatorio.ToString();
    }



    public virtual void Acumular() {}  
    public virtual void AdicionarBonus(){}

    

}