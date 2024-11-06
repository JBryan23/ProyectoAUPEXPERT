using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Common;

namespace AUPExpert.Application.Interface.UseCases.Iterations
{
    public interface IIterationApplication
    {
        Task<Response<bool>> InsertAsync(IterationDto iterationDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> UpdateAsync(IterationDto iterationDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> CompleteIterationAsync(IterationDto iterationDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> DeleteAsync(int iterationId, CancellationToken cancellationToken = default);
        Task<Response<IterationDto>> GetAsync(int iterationId, CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<IterationDto>>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Response<IEnumerable<IterationDto>>> GetIterationByProjectAndPhaseAsync(int projectId, PhaseDto phaseDto, CancellationToken cancellationToken = default);
        Task<Response<bool>> IsThisLastIterationPerProjectAndPhaseAsync(int id, int projectId, PhaseDto phaseDto, CancellationToken cancellationToken = default);
        Task<Response<int>> CountAllAsync(int projectId, CancellationToken cancellationToken = default);
    }
}
