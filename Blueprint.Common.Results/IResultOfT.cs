namespace Blueprint.Results
{
  public interface IResult<out T> : IResult
  {
    T Data { get; }
  }
}
