using System.Threading.Tasks;

namespace Blueprint.Results
{
  public class Result<T> : Result, IResult<T>, IResult
  {
    public T Data { get; set; }

    public new static Result<T> Fail()
    {
            Result<T> result = new()
            {
                Succeeded = false
            };
            return result;
    }

    public new static Result<T> Fail(string message)
    {
            Result<T> result = new()
            {
                Succeeded = false,
                Message = message
            };
            return result;
    }

    public new static Task<Result<T>> FailAsync() => Task.FromResult<Result<T>>(Result<T>.Fail());

    public new static Task<Result<T>> FailAsync(string message) => Task.FromResult<Result<T>>(Result<T>.Fail(message));

    public new static Result<T> Success()
    {
            Result<T> result = new()
            {
                Succeeded = true
            };
            return result;
    }

    public new static Result<T> Success(string message)
    {
            Result<T> result = new()
            {
                Succeeded = true,
                Message = message
            };
            return result;
    }

    public static Result<T> Success(T data)
    {
            Result<T> result = new()
            {
                Succeeded = true,
                Data = data
            };
            return result;
    }

    public static Result<T> Success(T data, string message)
    {
        Result<T> result = new() { Succeeded = true, Data = data, Message = message};
        return result;
    }

    public new static Task<Result<T>> SuccessAsync() => Task.FromResult<Result<T>>(Result<T>.Success());

    public new static Task<Result<T>> SuccessAsync(string message) => Task.FromResult<Result<T>>(Result<T>.Success(message));

    public static Task<Result<T>> SuccessAsync(T data) => Task.FromResult<Result<T>>(Result<T>.Success(data));

    public static Task<Result<T>> SuccessAsync(T data, string message) => Task.FromResult<Result<T>>(Result<T>.Success(data, message));
  }
}
