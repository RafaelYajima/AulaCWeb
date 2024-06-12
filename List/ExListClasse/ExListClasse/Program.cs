// See https://aka.ms/new-console-template for more information
using ExListClasse;

Console.WriteLine("Exemplo de list<classe>");
//criando um objetos para receber dados de pessoa
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Heitor";
pessoa1.Cpf = 123;

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Gabriel";
pessoa2.Cpf = 1234;

//adionando dados do tipo Pessoa no nosso List<Pessoa> da classe de repositorio
PessoaRepository.Pessoas.Add(pessoa1);
PessoaRepository.Pessoas.Add(pessoa2);

//Imprimindo os dados de List<Pessoa> da classe repositorio
foreach(var pessoa in PessoaRepository.Pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Nome} CPF: {pessoa.Cpf}");
}

//removendo dados do repositorio
PessoaRepository.Pessoas.Remove(pessoa1);

foreach (var pessoa in PessoaRepository.Pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Nome} CPF: {pessoa.Cpf}");
}