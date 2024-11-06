using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Application.Interface.UseCases.Iterations;
using AUPExpert.Application.Interface.UseCases.Projects;
using AUPExpert.Common;

namespace AUPExpert.Service.WebUI.Services.Iterations
{
    internal sealed class IterationService
    {
        private readonly IIterationApplication _iterationApplication;
        private readonly IProjectApplication _projectApplication;

        public IterationService(IIterationApplication iterationApplication, IProjectApplication projectApplication)
        {
            _iterationApplication = iterationApplication ?? throw new ArgumentNullException(nameof(iterationApplication));
            _projectApplication = projectApplication ?? throw new ArgumentNullException(nameof(projectApplication));
        }

        internal async Task<Response<bool>> InsertAsync(IterationDto iterationDto)
        {
            var response = new Response<bool>();

            // Verificar que los datos de la iteracion a insertar no sean nulos
            if (iterationDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            return await _iterationApplication.InsertAsync(iterationDto);
        }

        internal async Task<Response<bool>> UpdateAsync(int iterationId, IterationDto iterationDto)
        {
            var response = new Response<bool>();

            if (iterationId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si la iteracion existe
            var iterationDtoExists = await _iterationApplication.GetAsync(iterationId);
            if (iterationDtoExists.Data is null)
            {
                response.IsSuccess = iterationDtoExists.IsSuccess;
                response.Message = iterationDtoExists.Message;
                return response;  // Retornar inmediatamente si la iteracion no existe
            }

            // Verificar que los datos de la iteracion a actualizar no sean nulos
            if (iterationDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            response = await _iterationApplication.UpdateAsync(iterationDto);

            if (response.IsSuccess.Equals(false) && response.Message is null && response.Message is null)
            {
                response.IsSuccess = false;
                response.Message = "Debido a que los datos a actualizar son los mismos que los previos, para mejorar el rendimiento del programa no se han persistido los datos sobre la base de datos.";
            }

            return await Task.FromResult(response);
        }

        internal async Task<Response<bool>> CompleteIterationAsync(int iterationId, IterationDto iterationDto)
        {
            var response = new Response<bool>();

            if (iterationId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si la iteracion existe
            var iterationDtoExists = await _iterationApplication.GetAsync(iterationId);
            if (iterationDtoExists.Data is null)
            {
                response.IsSuccess = iterationDtoExists.IsSuccess;
                response.Message = iterationDtoExists.Message;
                return response;  // Retornar inmediatamente si la iteracion no existe
            }

            // Verificar que los datos de la iteracion a actualizar no sean nulos
            if (iterationDto is null)
            {
                response.IsSuccess = false;
                response.Message = "Datos a utilizar no encontrados.";
                return response;  // No continuar si no hay datos
            }

            response = await _iterationApplication.CompleteIterationAsync(iterationDto);

            if (response.IsSuccess.Equals(false) && response.Message is null && response.Message is null)
            {
                response.IsSuccess = false;
                response.Message = "Debido a que los datos a actualizar son los mismos que los previos, para mejorar el rendimiento del programa no se han persistido los datos sobre la base de datos.";
            }

            return await Task.FromResult(response);
        }

        internal async Task<Response<bool>> DeleteAsync(int iterationId)
        {
            var response = new Response<bool>();

            if (iterationId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si la iteracion existe
            var iterationDtoExists = await _iterationApplication.GetAsync(iterationId);
            if (iterationDtoExists.Data is null)
            {
                response.IsSuccess = iterationDtoExists.IsSuccess;
                response.Message = iterationDtoExists.Message;
                return response;  // Retornar inmediatamente si la iteracion no existe
            }

            return await _iterationApplication.DeleteAsync(iterationId);
        }

        internal async Task<Response<IterationDto>> GetAsync(int iterationId)
        {
            var response = new Response<IterationDto>();

            if (iterationId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }
            return await _iterationApplication.GetAsync(iterationId);
        }

        internal async Task<Response<IEnumerable<IterationDto>>> GetAllAsync()
        {
            return await _iterationApplication.GetAllAsync();
        }

        internal async Task<Response<IEnumerable<IterationDto>>> GetIterationByProjectAndPhaseAsync(int projectId, PhaseDto phaseDto)
        {
            return await _iterationApplication.GetIterationByProjectAndPhaseAsync(projectId, phaseDto);
        }

        internal async Task<Response<bool>> IsThisLastIterationPerProjectAndPhaseAsync(int id, int projectId, PhaseDto phaseDto)
        {
            var response = new Response<bool>();

            if (id == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador del registro no válido.";
                return response;
            }

            // Verificar si la iteracion existe
            var iterationDtoExists = await _iterationApplication.GetAsync(id);
            if (iterationDtoExists.Data is null)
            {
                response.IsSuccess = iterationDtoExists.IsSuccess;
                response.Message = iterationDtoExists.Message;
                return response;  // Retornar inmediatamente si la iteracion no existe
            }

            // Verificar si el proyecto existe
            var projectDtoExists = await _projectApplication.GetAsync(projectId);
            if (projectDtoExists.Data is null)
            {
                response.IsSuccess = projectDtoExists.IsSuccess;
                response.Message = projectDtoExists.Message;
                return response;  // Retornar inmediatamente si el proyecto no existe
            }

            return await _iterationApplication.IsThisLastIterationPerProjectAndPhaseAsync(id, projectId, phaseDto);
        }

        internal async Task<Response<int>> CountAllAsync(int projectId)
        {
            var response = new Response<int>();

            if (projectId == 0)
            {
                response.IsSuccess = false;
                response.Message = "Identificador de proyecto no válido.";
                return response;
            }
            return await _iterationApplication.CountAllAsync(projectId);
        }
    }
}
