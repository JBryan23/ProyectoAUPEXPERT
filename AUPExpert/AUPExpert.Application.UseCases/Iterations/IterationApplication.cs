using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Application.Interface.UseCases.Iterations;
using AUPExpert.Application.Validator;
using AUPExpert.Common;
using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using AutoMapper;

namespace AUPExpert.Application.UseCases.Iterations
{
    public sealed class IterationApplication: IIterationApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IterationDtoValidator _validationRules;

        public IterationApplication(IUnitOfWork unitOfWork, IMapper mapper, IterationDtoValidator validationRules)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _validationRules = validationRules ?? throw new ArgumentNullException(nameof(validationRules));
        }

        public async Task<Response<bool>> InsertAsync(IterationDto iterationDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(iterationDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo 
                var iteration = _mapper.Map<Iteration>(iterationDto);
                //guardamos en memoria
                await _unitOfWork.Iterations.InsertAsync(iteration, cancellationToken);

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

        public async Task<Response<bool>> UpdateAsync(IterationDto iterationDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(iterationDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo
                var iteration = _mapper.Map<Iteration>(iterationDto);

                //ejecutar accion en memoria
                await _unitOfWork.Iterations.UpdateAsync(iteration, cancellationToken);

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

        public async Task<Response<bool>> CompleteIterationAsync(IterationDto iterationDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar propiedades
                var validator = await _validationRules.ValidateAsync(iterationDto, cancellationToken);
                if (!validator.IsValid)
                {
                    //si no se valido correctamente
                    response.Message = "Errores de Validación.";
                    response.Errors = validator.Errors;
                    return response;
                }

                //realizar mapeo
                var iteration = _mapper.Map<Iteration>(iterationDto);

                //ejecutar accion en memoria
                await _unitOfWork.Iterations.UpdateAsync(iteration, cancellationToken);

                //persistir en la base de datos
                response.Data = await _unitOfWork.SaveAsync(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Finalización Existosa.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(int iterationId, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //ejecutar accion en memoria
                await _unitOfWork.Iterations.DeleteAsync(iterationId, cancellationToken);

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

        public async Task<Response<IEnumerable<IterationDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<IterationDto>>();
            try
            {
                //obtener datos
                var iterations = await _unitOfWork.Iterations.GetAllAsync(cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<IterationDto>>(iterations);
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

        public async Task<Response<IterationDto>> GetAsync(int iterationId, CancellationToken cancellationToken = default)
        {
            var response = new Response<IterationDto>();
            try
            {
                //budcar projecto
                var iteration = await _unitOfWork.Iterations.GetAsync(iterationId, cancellationToken);

                //validar si existe
                if (iteration is null)
                {
                    response.IsSuccess = true;
                    response.Message = "El projecto no existe.";
                }

                //mapear objeto 
                response.Data = _mapper.Map<IterationDto>(iteration);
                response.IsSuccess = true;
                response.Message = "Consulta Exitosa.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<IterationDto>>> GetIterationByProjectAndPhaseAsync(int projectId, PhaseDto phaseDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<IEnumerable<IterationDto>>();
            try
            {
                //obtener datos
                var iterations = await _unitOfWork.Iterations.GetIterationByProjectAndPhaseAsync(projectId,(Phase)phaseDto, cancellationToken);

                //realizar mapeo
                response.Data = _mapper.Map<IEnumerable<IterationDto>>(iterations);
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

        public async Task<Response<bool>> IsThisLastIterationPerProjectAndPhaseAsync(int id, int projectId, PhaseDto phaseDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                //validar el ultimo registro
                 response.Data = await _unitOfWork.Iterations.IsThisLastIterationPerProjectAndPhaseAsync(id, projectId, (Phase)phaseDto, cancellationToken);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa.";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Solo puede eliminarse la última iteración.";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<int>> CountAllAsync(int projectId, CancellationToken cancellationToken = default)
        {
            var response = new Response<int>();
            try
            {
                //obtener datos
                response.Data = await _unitOfWork.Iterations.CountAllAsync(projectId, cancellationToken);
                if (response.Data >= 0)
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
