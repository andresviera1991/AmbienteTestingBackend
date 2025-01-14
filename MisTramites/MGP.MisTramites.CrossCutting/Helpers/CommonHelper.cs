namespace MGP.MisTramites.CrossCutting.Helpers;
public static class CommonHelper
{
    public static readonly string OnlyDatePattern = "yyyy/MM/dd";

    public static readonly DateTime MinDate = DateTime.MinValue.ToUniversalTime();

    public static DateTime ParseDateTime(DateTime value)
    {
        DateTime dateOnly = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc);
        return dateOnly;
    }
}

