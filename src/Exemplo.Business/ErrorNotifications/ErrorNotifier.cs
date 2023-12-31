﻿using Exemplo.Business.Interfaces;

namespace Exemplo.Business.ErrorNotifications
{
    public class ErrorNotifier : IErrorNotifier
    {
        private List<ErrorNotification> _errorNotifications;

        public ErrorNotifier()
        {
            _errorNotifications = new List<ErrorNotification>();
        }

        public List<ErrorNotification> GetErrorNotifications()
        {
            return _errorNotifications;
        }

        public void Handle(ErrorNotification errorNotification)
        {
            _errorNotifications.Add(errorNotification);
        }

        public bool HasErrorNotification()
        {
            return _errorNotifications.Any();
        }
    }
}
