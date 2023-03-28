using classes;

var conta = new ContaBancaria("Pedro", 1000.50m); // "m" de monetário, vai ser tratado como moeda

Console.Write($"A conta {conta.Numero} foi criada por {conta.Cliente} com saldo inicial de {conta.Saldo}\n\n");

conta.EfetuarSaque(500, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");

conta.EfetuarDeposito(100, DateTime.Now, "Recebimento de um amigo");
Console.WriteLine($"Saldo Atual de {conta.Saldo}\n");
