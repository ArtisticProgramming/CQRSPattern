using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Core.Events
{
    public abstract class Event : Message , INotification
    {
        public DateTime Timestamp { get; set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
