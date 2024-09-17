namespace FactoryMethodConsoleApp.Factories
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override Notifications.Notification CreateNotification()
        {
            return new Notifications.EmailNotification();
        }
    }
}