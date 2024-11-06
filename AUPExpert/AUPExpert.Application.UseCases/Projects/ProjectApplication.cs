using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Application.Interface.UseCases.Projects;
using AUPExpert.Application.Validator;
using AUPExpert.Common;
using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using AutoMapper;

namespace AUPExpert.Application.UseCases.Projects
{
    public sealed class ProjectApplication : IProjectApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ProjectDtoValidator _validationRules;

        public ProjectApplication(IUnitOfWork unitOfWork, IMapper mapper, ProjectDtoValidator validationRules)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _validationRules = validationRules ?? throw new ArgumentNullException(nameof(validationRules));
        }

        public async Task<Response<bool>> InsertAsync(ProjectDto projectDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(projectDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo 
                var project = _mapper.Map<Project>(projectDto);
                //guardamos en memoria
                await _unitOfWork.Projects.InsertAsync(project, cancellationToken);

                //persistimos en la base de datos y guardamos el resultado
                response.Data = await _unitOfWork.SaveAsync(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Existoso.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> UpdateAsync(ProjectDto projectDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(projectDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo
                var project = _mapper.Map<Project>(projectDto);

                //ejecutar accion en memoria
                await _unitOfWork.Projects.UpdateAsync(project, cancellationToken);

                //persistir en la base de datos
                response.Data = await _unitOfWork.SaveAsync(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Existosa.";
                }
            } 
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(int projectId, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria
                await _unitOfWork.Projects.DeleteAsync(projectId, cancellationToken);

                //persistir en la base de datos
                response.Data = await _unitOfWork.SaveAsync(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Existosa.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<ProjectDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<ProjectDto>>();
            try
            {
                //obtener datos
                var projects = await _unitOfWork.Projects.GetAllAsync(cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<ProjectDto>>(projects);
                if(response.Data is not null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }
            }
            catch (Exception ex)
            {
                response.Message= ex.Message;
            }
            return response;
        }

        public async Task<Response<ProjectDto>> GetAsync(int projectId, CancellationToken cancellationToken = default)
        {
            var response = new Response<ProjectDto>();
            try
            {
                //budcar projecto
                var project = await _unitOfWork.Projects.GetAsync(projectId, cancellationToken);

                //validar si existe
                if(project is null)
                {
                    response.IsSuccess = true;
                    response.Message = "El projecto no existe.";
                }

                //mapear objeto 
                response.Data = _mapper.Map<ProjectDto>(project);
                response.IsSuccess = true;
                response.Message = "Consulta Exitosa.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> FinishProjectAsync(int projectId, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria
                var result = await _unitOfWork.Projects.FinishProjectAsync(projectId, cancellationToken);

                //persistir en la base de datos
                response.Data = await _unitOfWork.SaveAsync(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Finalización Existosa.";
                }


                if (!result)
                {
                    response.IsSuccess = false;
                    response.Message = "Es requerido completar las cuatro fases de la metodología previamente, para marcar el proyecto como FINALIZADO.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<bool>> CanCompletePhaseAsync(int projectId, PhaseDto phase, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria (encontrando iteraciones para el proyecto)
                var iterations = await _unitOfWork.Iterations.GetIterationByProjectAndPhaseAsync(projectId, (Phase)phase, cancellationToken);
                if(iterations is null || iterations.Count().Equals(0))
                {
                    response.IsSuccess = false;
                    response.Message = "Fase de proyecto sin Iteraciones.";
                    return response;
                }

                //evaluar cada iteracion y su estado, al detectar un Pendiente retornar falso
                foreach (var iteration in iterations) 
                {
                    var isEqual = iteration.State.Equals((IterationState)IterationStateDto.PENDIENTE);
                    if (isEqual)
                    {
                        response.IsSuccess = false;
                        response.Message = "Una o varias iteraciones no han sido finalizadas. Para completar una fase la finalización de las iteraciones es obligatoria.";
                        return response;
                    }
                }

                //persistir en la base de datos
                 response.Data = true;
                 response.IsSuccess = true;
                 response.Message = "Consulta Existosa.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
