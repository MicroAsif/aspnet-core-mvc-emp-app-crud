using SignalR.core.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.core.Model
{
    public class Notification : BaseModel
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }

        public NotificationType Type { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid? RegisterUserId { get; set; }
    }

    public enum NotificationType
    {
        General,
        UserRegistraion
    }
}
