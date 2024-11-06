using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using AUPExpert.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AUPExpert.Persistence.Repositories
{
    internal sealed class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<bool> InsertAsync(Project entity, CancellationToken cancellationToken)
        {
            await _applicationDbContext.AddAsync(entity, cancellationToken);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Project entity, CancellationToken cancellationToken)
        {
            var project = await _applicationDbContext.Set<Project>()
                //.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(entity.Id), cancellationToken);

            if (project is null) return await Task.FromResult(false);

            _applicationDbContext.Entry(project).CurrentValues.SetValues(entity);

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var project = await _applicationDbContext.Set<Project>()
                //.AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);

            if (project is null) return await Task.FromResult(false);

            _applicationDbContext.Remove(project);

            return await Task.FromResult(true);
        }

        public async Task<bool> FinishProjectAsync(int id, CancellationToken cancellationToken)
        {
            var project = await _applicationDbContext.Set<Project>()
                .Where(e => e.Id == id && 
                e.InitialPhaseCompleted.Equals(true) && 
                e.ElaborationPhaseCompleted.Equals(true) &&
                e.ConstructionPhaseCompleted.Equals(true) &&
                e.TransitionPhaseCompleted.Equals(true))
                .SingleOrDefaultAsync(cancellationToken);

            if(project is null) return await Task.FromResult(false);

            project.State = ProjectState.FINALIZADO;

            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<Project>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<Project>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Project> GetAsync(int id, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Set<Project>()
                .AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }
    }
}
