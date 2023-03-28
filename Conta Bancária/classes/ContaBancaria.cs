namespace classes;
public class ContaBancaria
{
    private static int numeroConta = 1234567890;
    public string Numero { get; }
    public string Cliente { get; set; } // set - habilita a atribuição de membros de dados, get - recupera valores do membro de dados.
    public decimal Saldo 
    {
        get 
        {
            decimal saldo = 0m; // "m" para ser tratado como monetário
            foreach (var item in todasTransacoes) 
            {
                saldo += item.Quantia; // "+=" operador de atribuição resumido, mesma coisa que saldo = saldo + item.quantia
            }
            return saldo;
        }
    }

    // métodos 
    // construtor ContaBancaria
    public ContaBancaria(string nome, decimal saldoInicial)
    {
        // this - os objetos são do objeto ContaBancaria
        this.Cliente = nome; 
        // this.Saldo = saldoInicial;
        this.Numero = numeroConta.ToString(); // ToString pois "Numero" é String e "numeroConta" int, então faz o cast (conversão)
        numeroConta++;
        EfetuarDeposito(saldoInicial, DateTime.Now, "Saldo Inicial ");
    }

    private List<Transacao> todasTransacoes = new List<Transacao>(); // adicionando lista associada á classe Transação

    public void EfetuarDeposito(decimal quantia, DateTime data, string nota)
    {
        if (quantia <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantia), "A quantia de depósito deve ser positiva"); 
            // A instrução throw lança uma exceção.
        }   
        var deposito = new Transacao(quantia, data, nota);
        todasTransacoes.Add(deposito);
    }

    public void EfetuarSaque(decimal quantia, DateTime data, string nota)
    {
        if (quantia <= 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(quantia), " A quantia de saque deve ser positiva");
        }  
        if (Saldo - quantia < 0) 
        {
            throw new InvalidOperationException("Fundo não suficiente para este saque");
        }
        var saque = new Transacao(-quantia, data, nota);
        todasTransacoes.Add(saque);
    }



}