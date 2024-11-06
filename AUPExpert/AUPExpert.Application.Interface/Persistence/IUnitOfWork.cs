namespace AUPExpert.Application.Interface.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        IProjectRepository Projects { get; }
        IIterationRepository Iterations { get; }
        IWorkFlowRespository WorkFlows { get; }
        IWorkFlowTaskRepository WorkFlowTasks { get; }

        //permitirá guardar la info en la base de datos
        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
