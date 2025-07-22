namespace JC_Rotas.Services.Interfaces
{
    public interface IRotaService
    {
        Task<(List<string> Caminho, decimal Custo)> BuscarMelhorRotaAsync(string origem, string destino);

    }
}
