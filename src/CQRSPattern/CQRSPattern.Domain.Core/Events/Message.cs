using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Core.Events
{
    public class Message : IRequest
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        public Message()
        {
            MessageType = this.GetType().Name;
        }
    }
}
