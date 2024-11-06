using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;

namespace AUPExpert.Application.Interface.Persistence
{
    public interface IIterationRepository:IGenericRepository<Iteration>
    {
        Task<IEnumerable<Iteration>> GetIterationByProjectAndPhaseAsync(int projectId, Phase phase, CancellationToken cancellationToken);
        Task<bool> IsThisLastIterationPerProjectAndPhaseAsync(int id, int projectId, Phase phase, CancellationToken cancellationToken);
        Task<int> CountAllAsync(int projectId, CancellationToken cancellationToken);
    }
}
