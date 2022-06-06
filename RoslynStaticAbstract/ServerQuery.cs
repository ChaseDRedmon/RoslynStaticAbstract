namespace RoslynStaticAbstract;

public interface IStatic<out T>
{
    static abstract T Parse(ReadOnlySpan<byte> text);
}

public class ServerQuery : IStatic<ServerQuery>
{
    public static ServerQuery Parse(ReadOnlySpan<byte> text)
    {
        throw new NotImplementedException();
    }
}