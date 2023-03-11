using ConsoleApp_Noite;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litro");

Console.WriteLine($"{p1.getDescricao()} {p1.getId()} R${p1.getValor()}");

Endereco endereco = new Endereco("Rua Teste 1", "1", "15996060", "Test A", "City X", "SP");

Cliente c1 = new Cliente(1, "Teste 1" , "856213401", endereco);
Cliente c2 = new Cliente(2, "Teste 2" , "856213402", endereco);
Cliente c3 = new Cliente(3, "Teste 3" , "856213403", endereco);
Cliente c4 = new Cliente(4, "Teste 4" , "856213404", endereco);
Cliente c5 = new Cliente(5, "Teste 5" , "856213405", endereco);

Console.WriteLine($"{c2.GetEndereco().getRua()} {c2.GetEndereco().getNumero()}");

c2.GetEndereco().setNumero("157");