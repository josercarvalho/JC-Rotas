using JC_Rotas.Domain.Entities;

namespace JC_Rotas.Infra.Interfaces
{
    public interface ITesteRepository
    {
        void AdicionarRota(Rota rota);
        List<Rota> ObterRotas();
    }
}
