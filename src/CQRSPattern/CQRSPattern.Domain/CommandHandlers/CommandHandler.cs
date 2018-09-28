using CQRSPattern.Domain.Core.Bus;
using CQRSPattern.Domain.Core.Commands;
using CQRSPattern.Domain.Core.Notifications;
using CQRSPattern.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.CommandHandlers
{
    public class CommandHandler
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediatorHandler bus;
        private readonly DomainNotificationHandler _notifications;
        //TODO
        public CommandHandler(IUnitOfWork unit, IMediatorHandler mediator , DomainNotificationHandler noti )
        {
            unitOfWork = unit;
            bus = mediator;
            _notifications = noti;
        }
        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                bus.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            if (unitOfWork.Commit()) return true;

            bus.RaiseEvent(new DomainNotification("Commit", "We had a problem during saving your data."));
            return false;
        }
    }
}
