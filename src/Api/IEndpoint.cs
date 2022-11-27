namespace Api;

public interface IEndpoint
{
    static abstract IEndpointRouteBuilder Map(IEndpointRouteBuilder endpoints);
}