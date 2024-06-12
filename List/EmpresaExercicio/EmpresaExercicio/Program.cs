// See https://aka.ms/new-console-template for more information
using EmpresaExercicio;

Console.WriteLine("Hello, World!");

Empresa empresa1 = new Empresa();
empresa1.Nome = "Ambev";
empresa1.Cnpj = 14152000128;
empresa1.AnoFundacao = 1980;

Empresa empresa2 = new Empresa();
empresa2.Nome = "Coca-cola";
empresa2.Cnpj = 15256000128;
empresa2.AnoFundacao = 1950;

Empresa empresa3 = new Empresa();
empresa3.Nome = "Vendraneli";
empresa3.Cnpj = 25890000128;
empresa3.AnoFundacao = 1990;

EmpresaRepository.Empresas.Add(empresa1);
EmpresaRepository.Empresas.Add(empresa2);
EmpresaRepository.Empresas.Add(empresa3);

foreach(var empresa in EmpresaRepository.Empresas)
{
    Console.WriteLine($"Empres:{empresa.Nome} CNPJ:{empresa.Cnpj} " +
                      $"Ano de Fundação: {empresa.AnoFundacao}");
}

Console.WriteLine("-----------------------------------------------");

EmpresaRepository.Empresas.Remove(empresa2);

foreach (var empresa in EmpresaRepository.Empresas)
{
    Console.WriteLine($"Empres:{empresa.Nome} CNPJ:{empresa.Cnpj} " +
                      $"Ano de Fundação: {empresa.AnoFundacao}");
}