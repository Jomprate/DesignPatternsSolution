namespace FactoryMethodConsoleApp.Factories
{
    public class SMSNotificationFactory : NotificationFactory
    {
        public override Notifications.Notification CreateNotification()
        {
            return new Notifications.SMSNotification();
        }
    }
}