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
        public T Value { get; set; }
        public string Error { get; set; }

        public static Result<T> Success(T value)
        {
            return new Result<T> { Value = value, IsSuccess = true };
        }

        public static Result<T> Failed(string error)
        {
            return new Result<T> { Error=error, IsSuccess = false };
        }

    }
}
