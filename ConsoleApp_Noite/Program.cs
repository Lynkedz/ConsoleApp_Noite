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
Cliente c5 = new Cliente(5, "Teste 5" , "856213405", endereco);

Console.WriteLine($"{c2.GetEndereco().getRua()} {c2.GetEndereco().getNumero()}");

c2.GetEndereco().setNumero("157");

Console.WriteLine($"{c2.GetEndereco().getNumero()}");*/

Carro gol = new Carro();
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

/*Console.WriteLine(monark.ExibirDados());
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
}*/

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


