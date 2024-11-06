using AUPExpert.Application.DTO;
using AUPExpert.Application.Interface.UseCases.Projects;
using AUPExpert.Application.Interface.UseCases.WorkFlows;
using AUPExpert.Common;

namespace AUPExpert.Service.WebUI.Services.WorkFlows
{
    internal sealed class WorkFlowService
    {
        private readonly IWorkFlowApplication _workFlowApplication;
        private readonly IProjectApplication _projectApplication;

        public WorkFlowService(IWorkFlowApplication workFlowApplication, IProjectApplication projectApplication)
        {
            _workFlowApplication = workFlowApplication ?? throw new ArgumentNullException(nameof(workFlowApplication));
            _projectApplication = projectApplication ?? throw new ArgumentNullException(nameof(projectApplication));
        }

        internal async Task<Response<bool>> InsertAsync(WorkFlowDto workFLowDto)
        {
            var response = new Response<bool>();

            // Verificar que los datos del flujo de trabajo a insertar no sean nulos
            if (workFLowDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            return await _workFlowApplication.InsertAsync(workFLowDto);
        }

        internal async Task<Response<bool>> UpdateAsync(int workFlowId, WorkFlowDto workFlowDto)
        {
            var response = new Response<bool>();

            if (workFlowId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si el flujo de trabajo existe
            var workFlowDtoExists = await _workFlowApplication.GetAsync(workFlowId);
            if (workFlowDtoExists.Data is null)
            {
                response.IsSuccess = workFlowDtoExists.IsSuccess;
                response.Message = workFlowDtoExists.Message;
                return response;  // Retornar inmediatamente si el flujo de trabajo no existe
            }

            // Verificar que los datos del flujo de trabajo a actualizar no sean nulos
            if (workFlowDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            response = await _workFlowApplication.UpdateAsync(workFlowDto);

            if (response.IsSuccess.Equals(false) && response.Message is null && response.Message is null)
            {
                response.IsSuccess = false;
                response.Message = "Debido a que los datos a actualizar son los mismos que los previos, para mejorar el rendimiento del programa no se han persistido los datos sobre la base de datos.";
            }

            return await Task.FromResult(response);
        }

        internal async Task<Response<bool>> DeleteAsync(int workFlowId)
        {
            var response = new Response<bool>();

            if (workFlowId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si el flujo de trabajo existe
            var workFlowDtoExists = await _workFlowApplication.GetAsync(workFlowId);
            if (workFlowDtoExists.Data is null)
            {
                response.IsSuccess = workFlowDtoExists.IsSuccess;
                response.Message = workFlowDtoExists.Message;
                return response;  // Retornar inmediatamente si el flujo de trabajo no existe
            }

            return await _workFlowApplication.DeleteAsync(workFlowId);
        }

        internal async Task<Response<WorkFlowDto>> GetAsync(int workFlowId)
        {
            var response = new Response<WorkFlowDto>();

            if (workFlowId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            return await _workFlowApplication.GetAsync(workFlowId);
        }

        internal async Task<Response<IEnumerable<WorkFlowDto>>> GetAllAsync()
        {
            return await _workFlowApplication.GetAllAsync();
        }

        internal async Task<Response<IEnumerable<WorkFlowDto>>> GetAllByProjectAsync(int projectId)
        {
            var response = new Response<IEnumerable<WorkFlowDto>>();

            if (projectId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del proyecto no válido.";
                return response;
            }
            // Verificar si el proyecto existe
            var projectDtoExists = await _projectApplication.GetAsync(projectId);
            if (projectDtoExists.Data is null)
            {
                response.IsSuccess = projectDtoExists.IsSuccess;
                response.Message = projectDtoExists.Message;
                return response;  // Retornar inmediatamente si el proyecto no existe
            }

            return await _workFlowApplication.GetAllByProjectAsync(projectId);
        }
    }
}
