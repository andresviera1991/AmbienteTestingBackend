using System;

namespace MGP.Authentication.CrossCutting.Helpers
{
    public static class CommonHelper
    {
        public static readonly string OnlyDatePattern = "yyyy/MM/dd";

        public static readonly DateTime MinDate = DateTime.MinValue.ToUniversalTime();

        public static DateTime ParseDateTime(DateTime value)
        {
            DateTime dateOnly = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc);
            return dateOnly;
        }

        public static bool IsUnderage(DateTime birthDate)
        {
            var age = DateTime.Now.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            return age < 18;
        }
    }
}

