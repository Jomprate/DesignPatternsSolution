namespace FactoryMethodConsoleApp.Factories
{
    public class PushNotificationFactory : NotificationFactory
    {
        public override Notifications.Notification CreateNotification()
        {
            return new Notifications.PushNotification();
        }
    }
}