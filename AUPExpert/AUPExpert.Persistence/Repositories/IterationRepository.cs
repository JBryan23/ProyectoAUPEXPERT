using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using AUPExpert.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AUPExpert.Persistence.Repositories
{
    internal sealed class IterationRepository: IIterationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public IterationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<bool> InsertAsync(Iteration entity, CancellationToken cancellationToken)
        {
            await _applicationDbContext.AddAsync(entity, cancellationToken);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Iteration entity, CancellationToken cancellationToken)
        {
            var iteration = await _applicationDbContext.Set<Iteration>()
                //.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(entity.Id), cancellationToken);

            if (iteration is null) return await Task.FromResult(false);

            _applicationDbContext.Entry(iteration).CurrentValues.SetValues(entity);

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var iteration = await _applicationDbContext.Set<Iteration>()
                //.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);

            if (iteration is null) return await Task.FromResult(false);

            _applicationDbContext.Remove(iteration);

            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<Iteration>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<Iteration>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Iteration> GetAsync(int id, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<Iteration>()
                .AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public async Task<int> CountAllAsync(int projectId, CancellationToken cancellationToken)
        {
            var iterations = await _applicationDbContext.Set<Iteration>()
            .AsNoTracking()
            .Where(e => e.ProjectId.Equals(projectId))
            .ToListAsync(cancellationToken);

            return await Task.FromResult(iterations.Count);
        }

        public async Task<IEnumerable<Iteration>> GetIterationByProjectAndPhaseAsync(int projectId, Phase phase, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<Iteration>()
            .AsNoTracking()
            .Where(e => e.ProjectId.Equals(projectId) && e.Phase.Equals(phase))
            .ToListAsync(cancellationToken);
        }

        public async Task<bool> IsThisLastIterationPerProjectAndPhaseAsync(int id, int projectId, Phase phase, CancellationToken cancellationToken)
        {
            var iteration = await _applicationDbContext.Set<Iteration>()
            .AsNoTracking()
            .Where(e => e.ProjectId.Equals(projectId) && e.Phase.Equals(phase))
            .OrderBy(e => e.Id)
            .LastAsync(cancellationToken);

            if (iteration is null) return await Task.FromResult(false);

            return (iteration.Id.Equals(id)) ? true : false;
        }
    }
}
