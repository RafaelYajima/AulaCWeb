// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo List<Hello, World!>");

//declaração dos list com tipos de dados simples
List<String> nomes = new List<String>();
List<int> cpfs = new List<int>();
//Adicionando valores string
nomes.Add("Heitor");
nomes.Add("Grabiel");
nomes.Add("Lucas");
//Adicionando valores inteiros
cpfs.Add(1234);
cpfs.Add(4567);
cpfs.Add(8901);

//Foreach para imprir nome
foreach(var nome in nomes)
{
    Console.WriteLine($"Nome:{nome}");
}

//Foreach para imprimir cpf
foreach(var cpf in cpfs)
{
    Console.WriteLine($"CPF:{cpf}");
}

