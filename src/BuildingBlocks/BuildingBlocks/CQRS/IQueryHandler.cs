namespace BuildingBlocks.CQRS;
using MediatR;

public interface IQueryHandler<in TCommand> 
    : IRequestHandler<TCommand, Unit> 
    where TCommand : ICommand<Unit>
{
    
}


public interface IQueryHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse> 
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
    
}