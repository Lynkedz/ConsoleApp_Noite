using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;

/*Produto p1 = new Produto(1, 10.90M, "Cervejinha");

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litro");

Console.WriteLine($"{p1.getDescricao()} {p1.getId()} R${p1.getValor()}");

Endereco endereco = new Endereco("Rua Teste 1", "1", "15996060", "Test A", "City X", "XX");

Cliente c1 = new Cliente(1, "Teste 1" , "856213401", endereco);
Cliente c2 = new Cliente(2, "Teste 2" , "856213402", endereco);
Cliente c3 = new Cliente(3, "Teste 3" , "856213403", endereco);
Cliente c4 = new Cliente(4, "Teste 4" , "856213404", endereco);
Cliente c5 = new Cliente(5, "Teste 5" , "856213405", endereco);*/

Produto p1 = new Produto(1, 10.90M, "Cervejinha");
p1.setId(1);
p1.setValor(10.90M);
p1.setDescricao("Cerveja Skol 1 litro");

Produto p2 = new Produto(2, 50.00M, "Carne");
p2.setId(2);
p2.setValor(50.00M);
p2.setDescricao("1Kg Carne");

Produto p3 = new Produto(3, 8.90M, "Arroz");
p3.setId(3);
p3.setValor(8.90M);
p3.setDescricao("Arroz Tio João 1kg");

Produto p4 = new Produto(4, 2.50M, "Salgadinho");
p4.setId(4);
p4.setValor(2.50M);
p4.setDescricao("Doritos 50g");

Produto p5 = new Produto(5, 5.00M, "Refrigerante");
p5.setId(5);
p5.setValor(5.00M);
p5.setDescricao("Coca-cola 2L");

Produto p6 = new Produto(6, 3.00M, "Feijão");
p6.setId(6);
p6.setValor(3.00M);
p6.setDescricao("Feijão Carioca 1kg");

Produto p7 = new Produto(7, 12.00M, "Picanha");
p7.setId(7);
p7.setValor(12.00M);
p7.setDescricao("Picanha Angus 1kg");

Produto p8 = new Produto(8, 1.50M, "Pão francês");
p8.setId(8);
p8.setValor(1.50M);
p8.setDescricao("Pão francês da padaria do seu Zé");

Produto p9 = new Produto(9, 7.90M, "Queijo");
p9.setId(9);
p9.setValor(7.90M);
p9.setDescricao("Queijo Minas frescal 500g");

Produto p10 = new Produto(10, 6.00M, "Macarrão");
p10.setId(10);
p10.setValor(6.00M);
p10.setDescricao("Macarrão espaguete Barilla 500g");


List<Produto> listaProduto = new List<Produto>();
listaProduto.Add(p1);
listaProduto.Add(p2);
listaProduto.Add(p3);
listaProduto.Add(p4);
listaProduto.Add(p5);
listaProduto.Add(p6);
listaProduto.Add(p7);
listaProduto.Add(p8);
listaProduto.Add(p9);
listaProduto.Add(p10);


/*Carro gol = new Carro();
gol.numeroAssentos = 5;
gol.temMotor = true;
gol.numeroPortas = 4;
gol.fabricante = "VM";
gol.cintoSeguranca = true;
gol.arCondicionado = true;  
gol.marcaRadio = "";


Bike monark = new Bike();
monark.temMotor = false;
monark.numeroAssentos = 1;
monark.numeroPortas = 0;

Carro saveiro = new Carro();
Carro palio = new Carro();
Carro uno = new Carro();

saveiro.fabricante = "VW";
saveiro.marcaRadio = "Sony";
saveiro.cintoSeguranca = true;
saveiro.arCondicionado = true;
saveiro.numeroPortas = 2;
saveiro.numeroAssentos = 2;
saveiro.temMotor = true;

palio.fabricante = "Fiat";
palio.marcaRadio = "Sony"; 
palio.cintoSeguranca = true;
palio.temMotor = true;
palio.numeroAssentos = 4;
palio.numeroPortas = 4;
palio.arCondicionado = true;


uno.fabricante = "Fiat";
uno.marcaRadio = "Sony";
uno.cintoSeguranca = true;
uno.arCondicionado = true;
uno.numeroAssentos = 4;
uno.numeroPortas = 4;
uno.temMotor = true;

Bike mountain  = new Bike();
mountain.temMotor = false;
mountain.numeroPortas  = 0;
mountain.numeroAssentos = 1;

Console.WriteLine(monark.ExibirDados());
Console.WriteLine(gol.ExibirDados());

List<Carro> listaCarro = new List<Carro>();
listaCarro.Add(gol);
listaCarro.Add(uno);
listaCarro.Add(palio);
listaCarro.Add(saveiro);

listaCarro[0].cintoSeguranca = true;
for (int i = 0; i < listaCarro.Count; i++)
{
    Console.WriteLine($"{listaCarro[i].ExibirDados()}");
}

foreach (var item in listaCarro)
{
    Console.WriteLine($"{item.ExibirMarca()}");
}

//Imprima na tela todos os clientes desse contexto
//Crie uma lista com 560 produtos
//Crie uma lista que aceite qualquer tipo de veiculo

List <Veiculo> listaVeiculo = new List<Veiculo>();
listaVeiculo.Add(uno);
listaVeiculo.Add(gol);
listaVeiculo.Add(palio);
listaVeiculo.Add(saveiro);
listaVeiculo.Add(monark);
listaVeiculo.Add(mountain);

foreach (var veiculo in listaVeiculo)
    Console.WriteLine($"{veiculo.ExibirDados()}");

for(int i = 0; i <= 560; i++)
{
    Produto p = new Produto(i ,10.0M, "Produto");
    Console.WriteLine($"Produto nº:{p.getId()} {p.getValor()} {p.getDescricao()}");
}

List<Cliente> listaCliente = new List<Cliente>();
for (int i = 0; i <= 50; i++)
{
    Endereco endereco = new Endereco("Rua Teste ", "", "15996060", "Test A", "City X", "XX");
    Cliente c = new Cliente(i, $"Teste {i}", "856213401", endereco);
    listaCliente.Add(c);
}

foreach (var cliente in listaCliente)
    Console.WriteLine($"{cliente.ExibirInformacao()}");*/

Venda venda1 = new Venda(1, "01/04/2023", listaProduto);

List<Venda> listaVenda = new List<Venda>();
listaVenda.Add(venda1);

foreach (var venda in listaVenda)
    Console.WriteLine(venda.ImprimirDados());

foreach (var produto in listaProduto)
    Console.WriteLine(produto.getId() +"\t" + produto.getValor() + "\t" + produto.getDescricao() + "\n");
//a lista aparece como System.Collections.Generic.List`1[ConsoleApp_Noite.Produto] 