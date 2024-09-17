namespace AbstractFactoryConsoleApp.Factories
{
    public class DarkThemeFactory : ThemeFactory
    {
        public override Themes.ColorScheme CreateColorScheme()
        {
            return new Themes.DarkColorScheme();
        }

        public override Themes.Layout CreateLayout()
        {
            return new Themes.DarkLayout();
        }

        public override Themes.TextStyle CreateTextStyle()
        {
            return new Themes.DarkTextStyle();
        }
    }
}