using AUPExpert.Application.DTO;
using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Application.Interface.UseCases.WorkFlowTasks;
using AUPExpert.Application.Validator;
using AUPExpert.Common;
using AUPExpert.Domain.Entities;
using AutoMapper;

namespace AUPExpert.Application.UseCases.WorkFlowTasks
{
    internal sealed class WorkFlowTaskApplication : IWorkFlowTaskApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly WorkFlowTaskDtoValidator _validationRules;

        public WorkFlowTaskApplication(IUnitOfWork unitOfWork, IMapper mapper, WorkFlowTaskDtoValidator validationRules)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _validationRules = validationRules ?? throw new ArgumentNullException(nameof(validationRules));
        }
        public async Task<Response<bool>> InsertAsync(WorkFlowTaskDto workFlowTaskDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(workFlowTaskDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo 
                var workFlowTask = _mapper.Map<WorkFlowTask>(workFlowTaskDto);
                //guardamos en memoria
                await _unitOfWork.WorkFlowTasks.InsertAsync(workFlowTask, cancellationToken);

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

        public async Task<Response<bool>> UpdateAsync(WorkFlowTaskDto workFlowTaskDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(workFlowTaskDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo
                var workFlowTask = _mapper.Map<WorkFlowTask>(workFlowTaskDto);

                //ejecutar accion en memoria
                await _unitOfWork.WorkFlowTasks.UpdateAsync(workFlowTask, cancellationToken);

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

        public async Task<Response<bool>> DeleteAsync(int workFlowTaskId, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria
                await _unitOfWork.WorkFlowTasks.DeleteAsync(workFlowTaskId, cancellationToken);

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

        public async Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<WorkFlowTaskDto>>();
            try
            {
                //obtener datos
                var workFlowTasks = await _unitOfWork.WorkFlowTasks.GetAllAsync(cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<WorkFlowTaskDto>>(workFlowTasks);
                if (response.Data is not null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<WorkFlowTaskDto>>> GetAllByIterationAsync(int workFlowTaskId, CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<WorkFlowTaskDto>>();
            try
            {
                //obtener datos
                var workFlowTasks = await _unitOfWork.WorkFlowTasks.GetAllByIterationAsync(workFlowTaskId, cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<WorkFlowTaskDto>>(workFlowTasks);
                if (response.Data is not null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<WorkFlowTaskDto>> GetAsync(int workFlowTaskId, CancellationToken cancellationToken = default)
        {
            var response = new Response<WorkFlowTaskDto>();
            try
            {
                //budcar projecto
                var workFlowTask = await _unitOfWork.WorkFlowTasks.GetAsync(workFlowTaskId, cancellationToken);

                //validar si existe
                if (workFlowTask is null)
                {
                    response.IsSuccess = true;
                    response.Message = "La tarea no existe no existe.";
                }

                //mapear objeto 
                response.Data = _mapper.Map<WorkFlowTaskDto>(workFlowTask);
                response.IsSuccess = true;
                response.Message = "Consulta Exitosa.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
