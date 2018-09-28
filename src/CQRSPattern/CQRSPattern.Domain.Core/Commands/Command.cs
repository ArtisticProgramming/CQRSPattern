using CQRSPattern.Domain.Core.Events;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
