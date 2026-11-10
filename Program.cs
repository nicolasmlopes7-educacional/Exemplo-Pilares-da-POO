using Heranca;

// Funcionario f = new Funcionario();

Gerente gerente = new Gerente();

gerente.Nome = "Davi";
gerente.Codigo = 134;
// gerente.Salario = 5000m;
gerente.DefinifrSalario(6700);

gerente.Trabalhar();
gerente.GerenciarEquipe();

Funcionario funcionario = new Gerente("Nicolas", 5000, 157);

Gerente gerente2 = new Gerente("Nicolas", 4000m, 123);

gerente.ExibirSalario();
gerente2.ExibirSalario();

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

f1.Trabalhar();
f2.Trabalhar();

Console.WriteLine(f1.CalcularBonus());
Console.WriteLine(f2.CalcularBonus());

Desenvolvedor d1 = new Desenvolvedor();

IPagamento pix = new PagamentoPix();
IPagamento cartao = new PagamentoCartao();

pix.Pagar(150m);
cartao.Pagar(200m);