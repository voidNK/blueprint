namespace Blueprint.Results
{
  public interface IResult
  {
    string Message { get; set; }

    bool Succeeded { get; set; }
  }
}
