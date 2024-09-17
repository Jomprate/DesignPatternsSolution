namespace AbstractFactoryConsoleApp.Factories
{
    public class LightThemeFactory : ThemeFactory
    {
        public override Themes.ColorScheme CreateColorScheme()
        {
            return new Themes.LightColorScheme();
        }

        public override Themes.Layout CreateLayout()
        {
            return new Themes.LightLayout();
        }

        public override Themes.TextStyle CreateTextStyle()
        {
            return new Themes.LightTextStyle();
        }
    }
}