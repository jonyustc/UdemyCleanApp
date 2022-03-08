using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class Result<T>
    {
        public Result(IReadOnlyList<T> values, Pagination pagination)
        {
            Values = values;
            Pagination = pagination;
            //Pagination.PageSize = pageSize;
            //Pagination.PageIndex = pageIndex;
            //Pagination.Total = total;
        }

        public Result(IReadOnlyList<T> values, bool isSuccess)
        {
            IsSuccess = isSuccess;
            Values = values;
        }

        public Result(IEnumerable<string> errors,bool isSuccess)
        {
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public Result(bool isSuccess, bool isInvalid, IEnumerable<string> errors)
        {
            IsSuccess = isSuccess;
            IsInvalid = isInvalid;
            Errors = errors;
        }

        public Result(IEnumerable<string> errors,bool isSuccess, int statusCode )
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Errors = errors;
        }

        public Result(IEnumerable<string> errors, bool isSuccess,bool invalid, int statusCode)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Errors = errors;
            IsInvalid = invalid;
        }

        public Result(IEnumerable<string> errors, bool isSuccess, int statusCode,string details)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Errors = errors;
            Details = details;
        }

        public bool IsSuccess { get; set; }
        public bool IsInvalid { get; set; }
        //public T Value { get; set; }
        public IReadOnlyList<T> Values { get; set; }
        //public string Error { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string Details { get; set; }


        //public int PageSize { get; set; } = 50;
        //public int PageIndex { get; set; } = 1;
        //public int Total { get; set; }

        public Pagination Pagination { get; set; }

        //public static Result<T> Success(T value)
        //{
        //    return new Result<T> { Value = value, IsSuccess = true };
        //}

        public static Result<T> Success(IReadOnlyList<T> values)
        {
            return new Result<T>(values,true);
        }

        public static Result<T> Failed(IEnumerable<string> errors)
        {
            return new Result<T>(errors,false);
        }

        public static Result<T> ValidationFailed(IEnumerable<string> errors)
        {
            return new Result<T>(false,true, errors);
        }

        public static Result<T> CreatePagination(IQueryable<T> source, int pageNumber,int pageSize)
        {
            int count = source.Count();

            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            var pagination = new Pagination(pageSize, pageNumber, count);
            return new Result<T>(items, pagination);
        }

    }
}
