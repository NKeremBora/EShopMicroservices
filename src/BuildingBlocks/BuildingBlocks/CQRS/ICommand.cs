namespace BuildingBlocks.CQRS;
using MediatR;

public interface ICommand : IRequest<Unit>
{
    
}

public interface ICommand<out TResult> : IRequest<TResult>
{
    
}