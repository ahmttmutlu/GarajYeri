namespace GarajYeri.Web
{
    public static class Helper
    {
        public static string Buyut(this string s)
        {
            return s.ToUpper();
        }
        public static string ToTitleCase(this string s)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
        }

        public static void ServisleriEkle(this IServiceCollection services)
        {

        }
    }
}
}
