using AUPExpert.Application.DTO;
using AUPExpert.Common;
using AUPExpert.Domain.Entities;

namespace AUPExpert.Application.Interface.UseCases.WorkFlows
{
    public interface IWorkFlowApplication
    {
        Task<Response<bool>> InsertAsync(WorkFlowDto workFlowDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> UpdateAsync(WorkFlowDto WorkFlowDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> DeleteAsync(int WorkFlowId, CancellationToken cancellationToken = default);
        Task<Response<WorkFlowDto>> GetAsync(int WorkFlowId, CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<WorkFlowDto>>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<WorkFlowDto>>> GetAllByProjectAsync(int ProjectId, CancellationToken cancellationToken = default);
    }
}
