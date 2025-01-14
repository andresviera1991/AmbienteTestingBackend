using System;
using System.Globalization;
namespace MGP.Discapacidad.CrossCutting.Helpers;
public static class CommonHelper
{
    public static readonly string OnlyDatePattern = "yyyy-MM-dd";
    private static readonly string DateTimePattern = "yyyy-MM-ddThh:mm:ss";

    public static readonly DateTime MinDate = DateTime.MinValue.ToUniversalTime();
    public static bool IsDateFormat(string date)
    {
        return DateTime.TryParseExact(date, CommonHelper.OnlyDatePattern, null, DateTimeStyles.AdjustToUniversal, out DateTime val);
    }

    public static DateTime ParseDateTime(string value)
    {
        if (DateTime.TryParseExact(value, DateTimePattern, null, DateTimeStyles.None, out DateTime dateTimeValue))
        {
            return dateTimeValue;
        }

        return DateTime.Parse(value);
    }
}

