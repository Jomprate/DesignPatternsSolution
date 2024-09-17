namespace FactoryMethodConsoleApp.Factories
{
    public abstract class NotificationFactory
    {
        public abstract Notifications.Notification CreateNotification();
    }
}