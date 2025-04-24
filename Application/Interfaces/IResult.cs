namespace OWF.API.Application.Interfaces;

public interface IResult<T> : IResult
{
    public T Result { get; set; }
    public Exception Exception { get; set; }
}

public interface IResult
{
    public static int SUCCESS = 200;
    public static int ERROR = 400;
    public static int NOT_FOUND = 404;
    public static int CONFLICT = 409;
    public static int SERVER_ERROR = 500;

    public int Status { get; set; }
    public bool IsSuccessful { get; set; }
}