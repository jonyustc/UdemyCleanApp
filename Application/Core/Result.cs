using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public bool IsInvalid { get; set; }
        public T Value { get; set; }
        //public string Error { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string Details { get; set; }

        public static Result<T> Success(T value)
        {
            return new Result<T> { Value = value, IsSuccess = true };
        }

        public static Result<T> Failed(IEnumerable<string> errors)
        {
            return new Result<T> { Errors = errors, IsSuccess = false };
        }

        public static Result<T> ValidationFailed(IEnumerable<string> errors)
        {
            return new Result<T> { Errors = errors, IsSuccess=false,IsInvalid=true };
        }

    }
}
