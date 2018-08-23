using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Infra.DomainEvent.Bus
{
    public class InMemoryBus
    {
        private readonly IMediator _mediator;


        //public Task SendCommand<T>(T command) // where T : Command
        //{
        //    return  _mediator.Send(command);
        //}
    }
}
