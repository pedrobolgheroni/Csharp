using SP3072134ControleDeGastos;

var gasto = new Gastos("Pedro");

var educacao = new Educacao("Pedro");

educacao.AdicionarValor(0, DateTime.Now, "Valor Inicial");
educacao.AdicionarValor(1000, DateTime.Now, "Linguaguem C#");
educacao.Acumular();

Console.WriteLine(educacao.ObterHistoricodeConta());

var natacao = new Natacao("Pedro");

natacao.AdicionarValor(0, DateTime.Now, "Valor Inicial");
natacao.AdicionarValor(200, DateTime.Now, "Aula Natação");
natacao.AdicionarValor(50, DateTime.Now, "Acessórios");
natacao.Acumular();

Console.WriteLine(natacao.ObterHistoricodeConta());

var danca = new Danca("Pedro", 50);

danca.AdicionarValor(0, DateTime.Now, "Valor Inicial");
danca.AdicionarValor(100, DateTime.Now, "Zumba");
danca.AdicionarValor(50, DateTime.Now, "Roupas Novas");
danca.Acumular();
danca.AdicionarValor(-50, DateTime.Now, "Bônus para Dança");

Console.WriteLine(danca.ObterHistoricodeConta());

var judo = new Judo("Pedro");

judo.AdicionarValor(0, DateTime.Now, "Valor Inicial");
judo.AdicionarValor(70, DateTime.Now, "Mensalidade Judô");
judo.AdicionarValor(55, DateTime.Now, "Faixa nova");
judo.Acumular();

Console.WriteLine(judo.ObterHistoricodeConta());

