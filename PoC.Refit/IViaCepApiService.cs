using Refit;
using System.Threading.Tasks;

namespace PoC.Refit
{
    public interface IViaCepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<EnderecoResponse> ObterEnderecoPorCepAsync(string cep);
    }
}
