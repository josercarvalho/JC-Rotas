using FluentValidation.Results;
using FluentValidation;
using System.Text;

namespace JC_Rotas.Domain.Entities;

public abstract class Base
{
    /// <summary>
    /// Identificador único da rota.
    /// </summary>
    public int Id { get; init; }

}
