using AUPExpert.Application.DTO;
using AUPExpert.Application.Interface.UseCases.Iterations;
using AUPExpert.Application.Interface.UseCases.WorkFlowTasks;
using AUPExpert.Common;

namespace AUPExpert.Service.WebUI.Services.WorkFlowTasks
{
    internal sealed class WorkFlowTaskService
    {
        private readonly IWorkFlowTaskApplication _workFlowTaskApplication;
        private readonly IIterationApplication _iterationApplication;

        public WorkFlowTaskService(IWorkFlowTaskApplication workFlowTaskApplication, IIterationApplication iterationApplication)
        {
            _workFlowTaskApplication = workFlowTaskApplication ?? throw new ArgumentNullException(nameof(workFlowTaskApplication));
            _iterationApplication = iterationApplication ?? throw new ArgumentNullException(nameof(iterationApplication));
        }

        internal async Task<Response<bool>> InsertAsync(WorkFlowTaskDto workFLowTaskDto)
        {
            var response = new Response<bool>();

            if (workFLowTaskDto.WorkFlowId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del flujo de trabajo no válido.";
                return response;
            }

            // Verificar que los datos del flujo de trabajo a insertar no sean nulos
            if (workFLowTaskDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            return await _workFlowTaskApplication.InsertAsync(workFLowTaskDto);
        }

        internal async Task<Response<bool>> UpdateAsync(int workFlowTaskId, WorkFlowTaskDto workFlowTaskDto)
        {
            var response = new Response<bool>();

            if (workFlowTaskId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si el flujo de trabajo existe
            var workFlowDtoExists = await _workFlowTaskApplication.GetAsync(workFlowTaskId);
            if (workFlowDtoExists.Data is null)
            {
                response.IsSuccess = workFlowDtoExists.IsSuccess;
                response.Message = workFlowDtoExists.Message;
                return response;  // Retornar inmediatamente si el flujo de trabajo no existe
            }

            // Verificar que los datos del flujo de trabajo a actualizar no sean nulos
            if (workFlowTaskDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            response = await _workFlowTaskApplication.UpdateAsync(workFlowTaskDto);

            if (response.IsSuccess.Equals(false) && response.Message is null && response.Message is null)
            {
                response.IsSuccess = false;
                response.Message = "Debido a que los datos a actualizar son los mismos que los previos, para mejorar el rendimiento del programa no se han persistido los datos sobre la base de datos.";
            }

            return await Task.FromResult(response);
        }

        internal async Task<Response<bool>> DeleteAsync(int workFlowTaskId)
        {
            var response = new Response<bool>();

            if (workFlowTaskId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si el flujo de trabajo existe
            var workFlowDtoExists = await _workFlowTaskApplication.GetAsync(workFlowTaskId);
            if (workFlowDtoExists.Data is null)
            {
                response.IsSuccess = workFlowDtoExists.IsSuccess;
                response.Message = workFlowDtoExists.Message;
                return response;  // Retornar inmediatamente si el flujo de trabajo no existe
            }

            return await _workFlowTaskApplication.DeleteAsync(workFlowTaskId);
        }

        internal async Task<Response<WorkFlowTaskDto>> GetAsync(int workFlowTaskId)
        {
            var response = new Response<WorkFlowTaskDto>();

            if (workFlowTaskId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            return await _workFlowTaskApplication.GetAsync(workFlowTaskId);
        }

        internal async Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllAsync()
        {
            return await _workFlowTaskApplication.GetAllAsync();
        }

        internal async Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllByIterationAsync(int iterationId)
        {
            var response = new Response<IEnumerable<WorkFlowTaskDto>>();

            if (iterationId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del proyecto no válido.";
                return response;
            }
            // Verificar si el proyecto existe
            var projectDtoExists = await _iterationApplication.GetAsync(iterationId);
            if (projectDtoExists.Data is null)
            {
                response.IsSuccess = projectDtoExists.IsSuccess;
                response.Message = projectDtoExists.Message;
                return response;  // Retornar inmediatamente si el proyecto no existe
            }

            return await _workFlowTaskApplication.GetAllByIterationAsync(iterationId);
        }
    }
}
