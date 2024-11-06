using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Application.Interface.UseCases.Projects;
using AUPExpert.Common;

namespace AUPExpert.Service.WebUI.Services.Projects
{
    internal sealed class ProjectService
    {
        private readonly IProjectApplication _projectApplication;

        public ProjectService(IProjectApplication projectApplication)
        {
            _projectApplication = projectApplication?? throw new ArgumentNullException(nameof(projectApplication));
        }

        internal async Task<Response<bool>> InsertAsync(ProjectDto projectDto)
        {
            var response = new Response<bool>();

            // Verificar que los datos del proyecto a insertar no sean nulos
            if (projectDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            return await _projectApplication.InsertAsync(projectDto);
        }

        internal async Task<Response<bool>> UpdateAsync( int projectId, ProjectDto projectDto)
        {
            var response = new Response<bool>();

            if (projectId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
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

            // Verificar que los datos del proyecto a actualizar no sean nulos
            if (projectDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            response = await _projectApplication.UpdateAsync(projectDto);

            if (response.IsSuccess.Equals(false) && response.Message is null && response.Message is null)
            {
                response.IsSuccess = false;
                response.Message = "Debido a que los datos a actualizar son los mismos que los previos, para mejorar el rendimiento del programa no se han persistido los datos sobre la base de datos.";
            }

            return await Task.FromResult(response);
        }

        internal async Task<Response<bool>> DeleteAsync( int projectId)
        {
            var response = new Response<bool>();

            if (projectId == 0) 
            { 
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
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

            return await _projectApplication.DeleteAsync(projectId);
        }

        internal async Task<Response<bool>> FinishProjectAsync(int projectId, ProjectStateDto stateDto)
        {
            var response = new Response<bool>();

            if (projectId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            if (stateDto.Equals(ProjectStateDto.FINALIZADO))
            {
                response.IsSuccess = false;
                response.Message = "El proyecto ya se ha marcado como FINALIZADO.";
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

            return await _projectApplication.FinishProjectAsync(projectId);
        }

        internal async Task<Response<bool>> CanCompletePhaseAsync(int projectId, PhaseDto phase)
        {
            var response = new Response<bool>();

            if (projectId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador de proyecto no válido.";
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

            return await _projectApplication.CanCompletePhaseAsync(projectId, phase);
        }

        internal async Task<Response<ProjectDto>> GetAsync(int projectId)
        {
            var response = new Response<ProjectDto>();

            if (projectId == 0) 
            { 
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }
            return await _projectApplication.GetAsync(projectId);
        }

        internal async Task<Response<IEnumerable<ProjectDto>>> GetAllAsync()
        {
            return await _projectApplication.GetAllAsync();
        }

    }
}
