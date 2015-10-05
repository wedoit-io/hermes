﻿namespace Apexnet.Dispatch.Api
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Apexnet.Messaging.Mail;
    using Apexnet.Messaging.Push;

    public abstract class BaseBundleRequest : IBundleRequest
    {
        protected BaseBundleRequest()
        {
            this.MailMessages = new Collection<MailMessage>();
            this.ApexnetPushNotifications = new Collection<ApexnetPushNotification>();
        }

        public ICollection<MailMessage> MailMessages { get; private set; }

        public ICollection<ApexnetPushNotification> ApexnetPushNotifications { get; private set; }
    }
}