namespace Blueprint.ThrowR
{
  public class Throw : IThrow
  {
    public static IThrow Exception { get; } = (IThrow) new Throw();

    private Throw()
    {
    }
  }
}
