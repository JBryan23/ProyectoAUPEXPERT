using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Domain.Entities;
using AUPExpert.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AUPExpert.Persistence.Repositories
{
    internal sealed class WorkFlowRepository: IWorkFlowRespository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public WorkFlowRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<bool> InsertAsync(WorkFlow entity, CancellationToken cancellationToken)
        {
            await _applicationDbContext.AddAsync(entity, cancellationToken);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(WorkFlow entity, CancellationToken cancellationToken)
        {
            var workFlow = await _applicationDbContext.Set<WorkFlow>()
                //.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(entity.Id), cancellationToken);

            if (workFlow is null) return await Task.FromResult(false);

            //workFlow.Name = entity.Name;
            //workFlow.Description = entity.Description;

            //_applicationDbContext.Update(workFlow);
            _applicationDbContext.Entry(workFlow).CurrentValues.SetValues(entity);

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var workFlow = await _applicationDbContext.Set<WorkFlow>()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);

            if (workFlow is null) return await Task.FromResult(false);

            _applicationDbContext.Remove(workFlow);

            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<WorkFlow>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlow>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<WorkFlow> GetAsync(int id, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlow>()
                .AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<IEnumerable<WorkFlow>> GetAllByProjectAsync(int ProjectId, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<WorkFlow>()
                .AsNoTracking()
                .Where(e => e.ProjectId.Equals(ProjectId))
                .ToListAsync(cancellationToken);
        }
    }
}
