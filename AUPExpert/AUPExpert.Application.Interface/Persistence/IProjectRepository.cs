using AUPExpert.Domain.Entities;

namespace AUPExpert.Application.Interface.Persistence
{
    public interface IProjectRepository: IGenericRepository<Project>
    {
        Task<bool> FinishProjectAsync(int id, CancellationToken cancellationToken);
    }
}
