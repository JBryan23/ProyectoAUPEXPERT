using AUPExpert.Application.DTO;
using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Application.Interface.UseCases.WorkFlows;
using AUPExpert.Application.Validator;
using AUPExpert.Common;
using AUPExpert.Domain.Entities;
using AutoMapper;

namespace AUPExpert.Application.UseCases.WorkFlows
{
    public sealed class WorkFlowApplication: IWorkFlowApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly WorkFlowDtoValidator _validationRules;

        public WorkFlowApplication(IUnitOfWork unitOfWork, IMapper mapper, WorkFlowDtoValidator validationRules)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _validationRules = validationRules ?? throw new ArgumentNullException(nameof(validationRules));
        }

        public async Task<Response<bool>> InsertAsync(WorkFlowDto workFlowDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(workFlowDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo 
                var workFlow = _mapper.Map<WorkFlow>(workFlowDto);
                //guardamos en memoria
                await _unitOfWork.WorkFlows.InsertAsync(workFlow, cancellationToken);

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

        public async Task<Response<bool>> UpdateAsync(WorkFlowDto workFlowDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(workFlowDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo
                var workFlow = _mapper.Map<WorkFlow>(workFlowDto);

                //ejecutar accion en memoria
                await _unitOfWork.WorkFlows.UpdateAsync(workFlow, cancellationToken);

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
        public async Task<Response<bool>> DeleteAsync(int workFlowId, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria
                await _unitOfWork.WorkFlows.DeleteAsync(workFlowId, cancellationToken);

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

        public async Task<Response<IEnumerable<WorkFlowDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<WorkFlowDto>>();
            try
            {
                //obtener datos
                var workFlows = await _unitOfWork.WorkFlows.GetAllAsync(cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<WorkFlowDto>>(workFlows);
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

        public async Task<Response<WorkFlowDto>> GetAsync(int workFlowId, CancellationToken cancellationToken = default)
        {
            var response = new Response<WorkFlowDto>();
            try
            {
                //budcar projecto
                var workFlow = await _unitOfWork.WorkFlows.GetAsync(workFlowId, cancellationToken);

                //validar si existe
                if (workFlow is null)
                {
                    response.IsSuccess = true;
                    response.Message = "El projecto no existe.";
                }

                //mapear objeto 
                response.Data = _mapper.Map<WorkFlowDto>(workFlow);
                response.IsSuccess = true;
                response.Message = "Consulta Exitosa.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<WorkFlowDto>>> GetAllByProjectAsync(int ProjectId, CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<WorkFlowDto>>();
            try
            {
                //obtener datos
                var workFlows = await _unitOfWork.WorkFlows.GetAllByProjectAsync(ProjectId, cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<WorkFlowDto>>(workFlows);
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
    }
}
