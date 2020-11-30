using System;

public class Response
{
    public Response(bool succeeded = false, Exception exception = null)
    {
        Succeeded = succeeded;
        Exception = exception;
    }

    public bool Succeeded;
    public Exception Exception;
}
