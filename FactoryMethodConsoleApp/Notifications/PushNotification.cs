namespace FactoryMethodConsoleApp.Notifications
{
    public class PushNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Sending Push Notification");
        }
    }
}