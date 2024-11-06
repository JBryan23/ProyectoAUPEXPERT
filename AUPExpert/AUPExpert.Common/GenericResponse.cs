using FluentValidation.Results;

namespace AUPExpert.Common
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
