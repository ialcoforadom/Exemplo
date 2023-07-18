using Exemplo.Business.ErrorNotifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo.Business.Interfaces
{
    public interface IErrorNotifier
    {
        bool HasErrorNotification();
        List<ErrorNotification> GetErrorNotifications();
        void Handle(ErrorNotification errorNotification);
    }
}
