using JC_Rotas.Domain.Entities;

namespace JC_Rotas.Infra.Interfaces
{
    public interface IRotaRepository : IBaseRepository<Rota>
    {
        Task<(List<string> Caminho, decimal Custo)> BuscarMelhorRotaAsync(string origem, string destino);
    }
}
