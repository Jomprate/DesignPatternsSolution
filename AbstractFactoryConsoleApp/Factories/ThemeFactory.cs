namespace AbstractFactoryConsoleApp.Factories
{
    public abstract class ThemeFactory
    {
        public abstract Themes.ColorScheme CreateColorScheme();

        public abstract Themes.Layout CreateLayout();

        public abstract Themes.TextStyle CreateTextStyle();
    }
}