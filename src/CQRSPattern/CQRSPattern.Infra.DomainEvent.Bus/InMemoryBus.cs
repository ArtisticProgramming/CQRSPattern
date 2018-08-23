using CQRSPattern.Domain.Core.Bus;
using CQRSPattern.Domain.Core.Commands;
using CQRSPattern.Domain.Core.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSPattern.Infra.DomainEvent.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}

