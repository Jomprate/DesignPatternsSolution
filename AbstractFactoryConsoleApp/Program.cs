using AbstractFactoryConsoleApp.Factories;
using AbstractFactoryConsoleApp.Themes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("== Aplicación de Configuración de Temas ==");

        ApplyTheme(new DarkThemeFactory());

        ApplyTheme(new LightThemeFactory());
    }

    private static void ApplyTheme(ThemeFactory factory)
    {
        // Crear componentes del tema usando la fábrica
        ColorScheme colorScheme = factory.CreateColorScheme();
        Layout layout = factory.CreateLayout();
        TextStyle textStyle = factory.CreateTextStyle();

        // Aplicar el tema
        colorScheme.ApplyScheme();
        layout.ApplyLayout();
        textStyle.ApplyTextStyle();
    }
}