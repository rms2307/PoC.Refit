using Refit;
using System;
using System.Threading.Tasks;

namespace PoC.Refit
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var clientViaCep = RestService.For<IViaCepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe o CEP: ");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine($"Consultando CEP: {0}.", cepInformado);

                EnderecoResponse endereco = await clientViaCep.ObterEnderecoPorCepAsync(cepInformado);

                Console.WriteLine($"Rua {endereco.Logradouro}, {endereco.Bairro}, {endereco.Localidade}, {endereco.Uf}, {endereco.Cep}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na conculta do Cep: {ex.Message}");
            }
        }
    }
}
