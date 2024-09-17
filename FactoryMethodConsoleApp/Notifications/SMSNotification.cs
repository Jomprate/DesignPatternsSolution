namespace FactoryMethodConsoleApp.Notifications
{
    public class SMSNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }
}