using AUPExpert.Domain.Entities;

namespace AUPExpert.Application.Interface.Persistence
{
    public interface IWorkFlowRespository: IGenericRepository<WorkFlow>
    {
        Task<IEnumerable<WorkFlow>> GetAllByProjectAsync(int ProjectId, CancellationToken cancellationToken);
    }
}
