using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using AUPExpert.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AUPExpert.Persistence.Repositories
{
    internal sealed class WorkFlowTaskRepository: IWorkFlowTaskRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public WorkFlowTaskRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<bool> InsertAsync(WorkFlowTask entity, CancellationToken cancellationToken)
        {
            await _applicationDbContext.AddAsync(entity, cancellationToken);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(WorkFlowTask entity, CancellationToken cancellationToken)
        {
            var workFlowTask = await _applicationDbContext.Set<WorkFlowTask>()
                .SingleOrDefaultAsync(e => e.Id.Equals(entity.Id), cancellationToken);

            if (workFlowTask is null) return await Task.FromResult(false);

            _applicationDbContext.Entry(workFlowTask).CurrentValues.SetValues(entity);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var workFlowTask = await _applicationDbContext.Set<WorkFlowTask>()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);

            if (workFlowTask is null) return await Task.FromResult(false);

            _applicationDbContext.Remove(workFlowTask);

            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<WorkFlowTask>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlowTask>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<WorkFlowTask> GetAsync(int id, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlowTask>()
                .AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<IEnumerable<WorkFlowTask>> GetAllByIterationAsync(int iterationId, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlowTask>()
            .AsNoTracking()
            .Where(e => e.IterationId.Equals(iterationId))
            .ToListAsync(cancellationToken);
        }
    }
}
