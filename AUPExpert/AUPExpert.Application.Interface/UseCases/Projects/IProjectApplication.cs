using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Common;

namespace AUPExpert.Application.Interface.UseCases.Projects
{
    public interface IProjectApplication
    {
        Task<Response<bool>> InsertAsync(ProjectDto projectDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> UpdateAsync(ProjectDto projectDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> DeleteAsync(int projectId, CancellationToken cancellationToken = default);
        Task<Response<ProjectDto>> GetAsync(int projectId, CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<ProjectDto>>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Response<bool>> FinishProjectAsync(int projectId, CancellationToken cancellationToken = default);
        Task<Response<bool>> CanCompletePhaseAsync(int projectId, PhaseDto phase, CancellationToken cancellationToken = default);
    }
}
