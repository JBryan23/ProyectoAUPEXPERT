using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Persistence.Contexts;

namespace AUPExpert.Persistence.Repositories
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        public IProjectRepository Projects { get; }

        public IIterationRepository Iterations { get; }

        public IWorkFlowRespository WorkFlows { get; }

        public IWorkFlowTaskRepository WorkFlowTasks { get; }

        private readonly ApplicationDbContext _applicationDbContext;

        public UnitOfWork(
            IProjectRepository projects,
            IIterationRepository iterations, 
            IWorkFlowRespository workFlows, 
            IWorkFlowTaskRepository workFlowTasks, 
            ApplicationDbContext applicationDbContext)
        {
            Projects = projects ?? throw new ArgumentNullException(nameof(projects));
            Iterations = iterations ?? throw new ArgumentNullException(nameof(iterations));
            WorkFlows = workFlows ?? throw new ArgumentNullException(nameof(workFlows));
            WorkFlowTasks = workFlowTasks ?? throw new ArgumentNullException(nameof(workFlowTasks));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
