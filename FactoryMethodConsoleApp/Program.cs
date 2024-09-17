using FactoryMethodConsoleApp.Factories;
using FactoryMethodConsoleApp.Notifications;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear la fábrica de notificación por email
        NotificationFactory emailFactory = new EmailNotificationFactory();
        Notification emailNotification = emailFactory.CreateNotification();
        emailNotification.Send(); // Output: Sending Email Notification

        // Crear la fábrica de notificación por SMS
        NotificationFactory smsFactory = new SMSNotificationFactory();
        Notification smsNotification = smsFactory.CreateNotification();
        smsNotification.Send(); // Output: Sending SMS Notification

        // Crear la fábrica de notificación por push
        NotificationFactory pushFactory = new PushNotificationFactory();
        Notification pushNotification = pushFactory.CreateNotification();
        pushNotification.Send(); // Output: Sending Push Notification
    }
}