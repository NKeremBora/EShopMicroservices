namespace BuildingBlocks.CQRS;
using MediatR;

public interface IQueryHandler<in TQuery> 
    : IRequestHandler<TQuery, Unit> 
    where TQuery : ICommand<Unit>
{
    
}


public interface IQueryHandler<in TQuery, TResponse> 
    : IRequestHandler<TQuery, TResponse> 
    where TQuery : IQuery<TResponse>
    where TResponse : notnull
{
    
}