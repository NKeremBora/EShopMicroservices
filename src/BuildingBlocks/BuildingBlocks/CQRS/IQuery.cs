namespace BuildingBlocks.CQRS;
using MediatR;

public interface IQuery : IRequest<Unit>
{
    
}

public interface IQuery<out TResult> : IRequest<TResult>
{
    
}