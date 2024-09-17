namespace FactoryMethodConsoleApp.Notifications
{
    public class EmailNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }
}