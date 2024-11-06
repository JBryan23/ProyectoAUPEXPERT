using AUPExpert.Domain.Entities;

namespace AUPExpert.Application.Interface.Persistence
{
    public interface IWorkFlowTaskRepository: IGenericRepository<WorkFlowTask>
    {
        Task<IEnumerable<WorkFlowTask>> GetAllByIterationAsync(int iterationId, CancellationToken cancellationToken = default);
    }
}
