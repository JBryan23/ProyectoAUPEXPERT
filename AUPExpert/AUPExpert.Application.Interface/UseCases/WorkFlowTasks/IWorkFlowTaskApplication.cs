using AUPExpert.Application.DTO;
using AUPExpert.Common;

namespace AUPExpert.Application.Interface.UseCases.WorkFlowTasks
{
    public interface IWorkFlowTaskApplication
    {
        Task<Response<bool>> InsertAsync(WorkFlowTaskDto workFlowTaskDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> UpdateAsync(WorkFlowTaskDto workFlowTaskDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> DeleteAsync(int workFlowTaskId, CancellationToken cancellationToken = default);
        Task<Response<WorkFlowTaskDto>> GetAsync(int workFlowTaskId, CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllByIterationAsync(int workFlowTaskId, CancellationToken cancellationToken = default);
    }
}
