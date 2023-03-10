using ConsoleApp_Noite;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine($"{p1.getDescricao()}  {p1.getId()}");

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litro");

Console.WriteLine($"{p1.getDescricao()} {p1.getId()} {p1.getValor()}");